using System.Xml.Serialization;

namespace Vecho.Consumer.Model.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/tachographActivityPeriod/1")]
public enum TachographActivity
{
    Driving,
    Working,
    Available,
    Resting
}