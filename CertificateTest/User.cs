using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CertificateTest {
  [Serializable]
  [XmlType( Namespace = "http://server.hw.demo/" )]
  public class User {
    
    [XmlElement( ElementName = "name", Form = XmlSchemaForm.Unqualified, Order = 0 )]
    public string Name { get; set; }
  }
}