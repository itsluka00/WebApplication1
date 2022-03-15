using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public char Spol { get; set; }
        public string Oib { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int godinaStudija { get; set; }
        public bool redovanStudent { get; set; }
    }
}