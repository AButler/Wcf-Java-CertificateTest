using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CertificateTest {
  [MessageContract( WrapperName = "sayHi", WrapperNamespace = "http://server.hw.demo/", IsWrapped = true )]
  public class SayHiRequest {

    [MessageBodyMember( Name = "arg0", Namespace = "http://server.hw.demo/", Order = 0 )]
    [XmlElement( ElementName = "arg0", Form = XmlSchemaForm.Unqualified )]
    public string Message { get; set; }
  }
}