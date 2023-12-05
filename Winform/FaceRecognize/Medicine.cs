using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognize
{
    public class Medicine
    {
        public string name { get; set; }
        public String session { get; set; }
        public int dose { get; set; }
        public int numOfDays { get; set; }
        public int total { get; set; }

        public Medicine(String name, String session, int dose, int numofday, int total) { 
            this.name = name;  
            this.session = session;
            this.dose = dose;
            this.numOfDays = numofday;
            this.total = total;
           
        }
    }
}
