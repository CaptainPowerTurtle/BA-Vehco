using System.Xml.Serialization;

namespace Vehco.Domain.Models.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/tachographActivityPeriod/1")]
public enum CardSlot
{
    SlotOne,
    SlotTwo
}