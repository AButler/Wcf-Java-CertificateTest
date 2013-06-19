using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CertificateTest {
  [MessageContract( WrapperName = "getUsersResponse", WrapperNamespace = "http://server.hw.demo/", IsWrapped = true )]
  public class GetUsersResponse {
    [MessageBodyMember( Namespace = "http://server.hw.demo/", Order = 0, Name = "return" )]
    [XmlArray( Form = XmlSchemaForm.Unqualified )]
    [XmlArrayItem( "entry", Form = XmlSchemaForm.Unqualified, IsNullable = false )]
    public List<IdentifiedUser> Users { get; set; }
  }
}