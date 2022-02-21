using System.Xml.Serialization;

namespace Vehco.Domain.Models.DRTCumulation;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/drtCumulation/1")]
public class Address
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string City { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public string Street { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public string PostalCode { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public string Country { get; set; }
}