using System.Xml.Serialization;

namespace Vecho.Consumer.Model.General;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/position/1")]
public class GPSPositionDTO : PositionDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public decimal Altitude { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public decimal Speed { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public decimal Heading { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public DateTime Timestamp { get; set; }
}