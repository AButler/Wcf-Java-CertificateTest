using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CertificateTest {
  [MessageContract( WrapperName = "sayHiToUserResponse", WrapperNamespace = "http://server.hw.demo/", IsWrapped = true )]
  public class SayHiToUserResponse {

    [MessageBodyMember( Name = "return", Namespace = "http://server.hw.demo/", Order = 0 )]
    [XmlElement( ElementName = "return", Form = XmlSchemaForm.Unqualified )]
    public string Reponse { get; set; }
  }
}