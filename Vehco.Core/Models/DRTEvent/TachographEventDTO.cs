using System.Xml.Serialization;
using Vecho.Consumer.Model.DRTEvent;
using Vecho.Consumer.Model.General;
using Vehco.Domain.Models.DRTEvent;

namespace Vehco.Domain.Models.DRTEvent;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtEvent/1")]
public class TachographEventDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public TachographInformationDTO TachographInformation { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public TachographEventType TachographEventType { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public DriverDTO User { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public VehicleIdDTO Vehicle { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    public DateTime Timestamp { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    public PositionDTO Position { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
    public long Mileage { get; set; }

    public TachographEventDTO()
    {
        TachographInformation = new TachographInformationDTO();
        TachographEventType = new TachographEventType();
        User = new DriverDTO();
        Vehicle = new VehicleIdDTO();
        Position = new PositionDTO();
    }
}