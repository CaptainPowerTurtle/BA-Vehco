using System.Xml.Serialization;

namespace Vecho.Consumer.Model.General;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/entity/vehicleId/1")]
public class VehicleIdDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string Id { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public string RoadBoxId { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public string LicensePlateNumber { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public string ExternalId { get; set; }
}