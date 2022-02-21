using System.Xml.Serialization;

namespace Vehco.Domain.Models.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/tachographActivityPeriod/1")]
public class TachographInformationDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public CardDTO Card { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public CardSlot CardSlot { get; set; }

    public TachographInformationDTO()
    {
        Card = new CardDTO();
    }
}