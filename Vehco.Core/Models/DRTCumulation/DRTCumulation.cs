using System.Xml.Serialization;
using Vecho.Consumer.Model.General;

namespace Vehco.Domain.Models.DRTCumulation;

[XmlInclude(typeof(DRTDailyCumulation))]
[XmlInclude(typeof(DRTShiftCumulation))]
[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtCumulation/1")]
public class DRTCumulation
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public DriverDTO Driver { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public bool IsDeleted { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public bool IsModification { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public int TotalMeters { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    public int Driving { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    public int Working { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
    public int Available { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
    public int Rest { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
    public int OtherPaidTimeShift { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
    public int OtherPaidTimeNotShift { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
    public int OtherUnpaidTime { get; set; }
}