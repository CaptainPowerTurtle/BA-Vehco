using System.Xml.Serialization;

namespace Vehco.Consumer.Converter;

public class XmlHelper
{
    public static T FromStringToXml<T>(string xml) where T : class
    {
        var serializer = new XmlSerializer(typeof(T));

        using (var reader = new StringReader(xml))
        {
            return (T)serializer.Deserialize(reader);
        }
    }
}