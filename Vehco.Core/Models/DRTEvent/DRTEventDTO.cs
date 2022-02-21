using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Vecho.Consumer.Model.DRTEvent;

namespace Vehco.Domain.Models.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtEvent/1")]
public partial class DRTEventDTO
{
    [NotMapped]
    [XmlElement("TachographEvent", typeof(TachographEventDTO), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    [XmlElement("TachographActivityPeriod", typeof(TachographActivityPeriodDTO), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public object Item { get; set; }

}