using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognize
{
    public class User
    {
        public string Fullname { get; set; }
        public string Dob { get; set; }
        public User(string fullname, string dob)
        {
            Fullname = fullname;
            Dob = dob;
        }
    }
}
