using System;
using System.Diagnostics;
using System.Net;
using System.ServiceModel;
using CertificateTest;

namespace Client {
  public class Program {
    public static void Main( string[] args ) {
      BypassSslCheck();
      try {
        var client = new ChannelFactory<IHelloWorld>( "CustomBinding_IHelloWorld" ).CreateChannel();

        Console.WriteLine( client.SayHi( new SayHiRequest { Message = "World" } ).Reponse );

        var user = new User { Name = "World" };
        Console.WriteLine( client.SayHiToUser( new SayHiToUserRequest { User = user } ).Reponse );

        //say hi to some more users to fill up the map a bit
        user = new User { Name = "Galaxy" };
        Console.WriteLine( client.SayHiToUser( new SayHiToUserRequest { User = user } ).Reponse );

        user = new User { Name = "Universe" };
        Console.WriteLine( client.SayHiToUser( new SayHiToUserRequest { User = user } ).Reponse );

        Console.WriteLine();
        Console.WriteLine( "Users: " );
        var users = client.GetUsers( new GetUsersRequest() ).Users;

        foreach ( var e in users ) {
          Console.WriteLine( "  " + e.Id + ": " + e.User.Name );
        }
      } catch ( Exception ex ) {
        Console.WriteLine( "-- EXCEPTION --" );
        Console.WriteLine( ex );
      }

      Console.ReadLine();
    }

    private static void BypassSslCheck() {
      ServicePointManager.ServerCertificateValidationCallback += ( sender, certificate, chain, errors ) => {
        Debug.WriteLine( "Certificate Validation:" );
        Debug.WriteLine( certificate.ToString() );
        Debug.WriteLine( "Errors:" );
        Debug.WriteLine( errors.ToString() );
        return true;
      };
    }
  }
}
