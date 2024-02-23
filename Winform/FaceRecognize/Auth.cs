using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth.Providers;
using FireSharp.Config;
using FireSharp.Interfaces;
namespace FaceRecognize
{
    public class Auth
    {

        public static FirebaseAuthConfig config = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyCkiRh6pOgqJHc6_u0Z_5jRWEkbbKvmyXY",
            AuthDomain = "facerecognition-6c037.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }

        };
        public static FirebaseAuthClient authClient = new FirebaseAuthClient(config);
        public static String uid = null;

        public static String client_id = null;
        public static IFirebaseConfig mconfig = new FirebaseConfig
        {
            AuthSecret = "G4GUZnW4cd9AkPP7NOzYGy55NoPWtzxd7lI7nygU",
            BasePath = "https://facerecognition-6c037-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };
        public static IFirebaseClient mclient;


    }
}
