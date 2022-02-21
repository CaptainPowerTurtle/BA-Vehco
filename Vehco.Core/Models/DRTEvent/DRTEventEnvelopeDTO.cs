using System.Xml.Serialization;

namespace Vehco.Domain.Models.DRTEvent;

[XmlRoot(Namespace = "http://www.vehcogroup.com/com/vehco/drtEvent/1", ElementName = "DRTEventEnvelope")]
public class DRTEventEnvelopeDTO
{
    [XmlElement("DRTEvent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public DRTEventDTO[] DRTEvent { get; set; }

    [XmlAttribute(DataType = ("token"))]
    public string schemaVersion { get; set; }
}