using System.Xml.Serialization;

namespace Vecho.Consumer.Model.General;

[XmlInclude(typeof(GPSPositionDTO))]
[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/position/1")]
public class PositionDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public decimal Latitude { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public decimal Longitude { get; set; }
}