using System.Xml.Serialization;

namespace Vehco.Domain.Models.DRTCumulation;

[XmlRoot(Namespace = "http://www.vehcogroup.com/com/vehco/drtCumulation/1")]
public class DRTCumulationEnvelope
{
    [XmlElement("AggregationJobReference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string AggregationJobReference { get; set; }

    [XmlElement("DRTDailyCumulation", typeof(DRTDailyCumulation), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    [XmlElement("DRTShiftCumulation", typeof(DRTShiftCumulation), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public object[] Items { get; set; }
    [XmlAttribute(DataType = "token")]
    public string SchemaVersion { get; set; }
}