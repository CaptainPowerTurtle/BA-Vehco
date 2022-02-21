using System.Xml.Serialization;
using Vecho.Consumer.Model.DRTEvent;
using Vecho.Consumer.Model.General;

namespace Vehco.Domain.Models.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/tachographActivityPeriod/1")]
public partial class TachographActivityPeriodDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public TachographInformationDTO TachographInformation { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public TachographActivity TachographActivity { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public DriverDTO User { get; set; }

    [XmlElement("Vehicle", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public VehicleIdDTO[] Vehicle { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    public DateTime StartTimestamp { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    public DateTime EndTimestamp { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
    public PositionDTO StartPosition { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
    public PositionDTO EndPosition { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
    public long StartMileage { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
    public long EndMileage { get; set; }

    public TachographActivityPeriodDTO()
    {
        TachographInformation = new TachographInformationDTO();
        TachographActivity = new TachographActivity();
        User = new DriverDTO();
        Vehicle = new List<VehicleIdDTO>().ToArray();
        StartPosition = new PositionDTO();
        EndPosition = new PositionDTO();
    }
}