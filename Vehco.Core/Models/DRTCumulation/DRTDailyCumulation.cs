using System.Xml.Serialization;

namespace Vehco.Domain.Models.DRTCumulation;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtCumulation/1")]
public class DRTDailyCumulation : DRTCumulation
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public DateTime Timestamp { get; set; }
}