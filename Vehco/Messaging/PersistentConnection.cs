using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using ISession = Apache.NMS.ISession;

namespace Vehco.Consumer.Messaging;

public class PersistentConnection : IDisposable
{
    protected static ITextMessage message;

    private IMessageConsumer _consumer;
    private readonly IConnection _connection;

    private ISession _session;

    public PersistentConnection()
    {
        Uri connecturi = new Uri("activemq:tcp://192.168.0.16:61616");

        Console.WriteLine("About to connect to " + connecturi);

        var connectionFactory = new ConnectionFactory(connecturi);
        connectionFactory.PrefetchPolicy.QueuePrefetch = 5;
        _connection = connectionFactory.CreateConnection();
        _connection.Start();
        //_session = _connection.CreateSession();

    }

    public void Dispose()
    {
        _connection?.Close();
    }

    public IMessageConsumer CreateConsumer(string queueName)
    {
        //there have to be new session for each concurrent consumer
        _session = _connection.CreateSession(AcknowledgementMode.ClientAcknowledge);
        var queue = new ActiveMQQueue(queueName);
        _consumer = _session.CreateConsumer(queue);
        string thread = Thread.CurrentThread.ManagedThreadId.ToString();
        Console.WriteLine("This is the current thread " + thread);
        return _consumer;
    }

}