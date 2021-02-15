using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management.Models
{
    public class Student
    {

        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string CIN { get; set; }
        public string adresse { get; set; }
    }
}
