using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CertificateTest {
  [Serializable]
  [XmlType( Namespace = "http://server.hw.demo/" )]
  public class IdentifiedUser {

    [XmlElement( ElementName = "id", Form = XmlSchemaForm.Unqualified, Order = 0 )]
    public int Id { get; set; }

    [XmlElement( ElementName = "user", Form = XmlSchemaForm.Unqualified, Order = 1 )]
    public User User { get; set; }
  }
}