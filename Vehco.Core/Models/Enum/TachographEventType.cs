using System.Xml.Serialization;

namespace Vecho.Consumer.Model.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtEvent/1")]
public enum TachographEventType
{
    CardInserted,
    CardRemoved
}