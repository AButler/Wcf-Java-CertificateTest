using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace CertificateTest {
  [ServiceBehavior( InstanceContextMode = InstanceContextMode.Single )]
  public class HelloWorld: IHelloWorld {
    private readonly IDictionary<int, User> _users;

    public HelloWorld() {
      _users = new Dictionary<int, User>();
    }

    public GetUsersResponse GetUsers( GetUsersRequest request ) {
      return new GetUsersResponse {
        Users = _users.Select( u => new IdentifiedUser { Id = u.Key, User = u.Value } ).ToList()
      };
    }

    public SayHiToUserResponse SayHiToUser( SayHiToUserRequest request ) {
      _users.Add( _users.Count + 1, request.User );

      return new SayHiToUserResponse {
        Reponse = "Hello " + request.User.Name
      };
    }

    public SayHiResponse SayHi( SayHiRequest request ) {
      return new SayHiResponse {
        Reponse = "Hello " + request.Message
      };
    }
  }
}
