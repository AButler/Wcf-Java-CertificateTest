using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CertificateTest {
  [MessageContract( WrapperName = "sayHiToUser", WrapperNamespace = "http://server.hw.demo/", IsWrapped = true )]
  public class SayHiToUserRequest {

    [MessageBodyMember( Namespace = "http://server.hw.demo/", Order = 0 )]
    [XmlElement( ElementName = "arg0", Form = XmlSchemaForm.Unqualified )]
    public User User { get; set; }
  }
}