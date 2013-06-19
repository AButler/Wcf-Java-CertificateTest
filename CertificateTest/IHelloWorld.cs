using System.Net.Security;
using System.ServiceModel;

namespace CertificateTest {
  [ServiceContract( Name = "HelloWorld", Namespace = "http://server.hw.demo/", ProtectionLevel = ProtectionLevel.Sign )]
  //, ConfigurationName = "HelloWorld" )]
  public interface IHelloWorld {

    [OperationContract( Action = "getUsers", ReplyAction = "*", Name = "getUsers" )]
    [XmlSerializerFormat]
    [return: MessageParameter( Name = "return" )]
    GetUsersResponse GetUsers( GetUsersRequest request );

    [OperationContract( Action = "sayHiToUser", ReplyAction = "*", Name = "sayHiToUser" )]
    [XmlSerializerFormat]
    [return: MessageParameter( Name = "return" )]
    SayHiToUserResponse SayHiToUser( SayHiToUserRequest request );

    [OperationContract( Action = "sayHi", ReplyAction = "*", Name = "sayHi" )]
    [XmlSerializerFormat]
    [return: MessageParameter( Name = "return" )]
    SayHiResponse SayHi( SayHiRequest request );
  }
}