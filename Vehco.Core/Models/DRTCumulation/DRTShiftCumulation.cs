using System.Xml.Serialization;
using Vecho.Consumer.Model.General;

namespace Vehco.Domain.Models.DRTCumulation;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtCumulation/1")]
public class DRTShiftCumulation : DRTCumulation
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public DateTime StartTimestamp { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public DateTime EndTimestamp { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public PositionDTO StartPosition { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public PositionDTO EndPosition { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    public Address StartAddress { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    public Address EndAddress { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
    public int FerryDriving { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
    public int FerryWorking { get; set; }

    public DRTShiftCumulation()
    {
        StartAddress = new Address();
        EndAddress = new Address();
        StartPosition = new PositionDTO();
        EndPosition = new PositionDTO();
    }
}