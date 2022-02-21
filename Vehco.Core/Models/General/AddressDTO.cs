using System.Xml.Serialization;

namespace Vehco.Domain.Models.General;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/address/1")]
public class AddressDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string Country { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public string CountryCode { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
    public string City { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    public string Street { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    public string StreetNumber { get; set; }
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    public string PostalCode { get; set; }
}