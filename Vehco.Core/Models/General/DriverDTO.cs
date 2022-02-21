using System.Xml.Serialization;

namespace Vecho.Consumer.Model.General;

[XmlType(Namespace = "http://www.vehcogroup.com/com/vehco/entity/userId/1")]
public class DriverDTO
{
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    public string Id { get; set; }

    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
    public string UserName { get; set; }
}