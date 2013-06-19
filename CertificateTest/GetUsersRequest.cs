using System.ServiceModel;

namespace CertificateTest {
  [MessageContract( WrapperName = "getUsers", WrapperNamespace = "http://server.hw.demo/", IsWrapped = true )]
  public class GetUsersRequest {
  }
}