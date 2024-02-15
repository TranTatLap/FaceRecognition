using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognize
{
    public class Auth
    {
        public static FirebaseAuthConfig config = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyCkiRh6pOgqJHc6_u0Z_5jRWEkbbKvmyXY",
            AuthDomain = "https://facerecognition-6c037-default-rtdb.asia-southeast1.firebasedatabase.app/",

        };
        FirebaseAuthClient client = new FirebaseAuthClient(config);
        public Auth() { }

    }
}
