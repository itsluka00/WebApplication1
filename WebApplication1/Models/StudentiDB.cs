using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    public class StudentiDB
    {
        public List<Student> lista = new List<Student>();

        public StudentiDB()
        {
            lista.Add(new Student()
            {
                ID = 1,
                Prezime = "Peric",
                Ime = "Pero",
                Spol = 'M',
                datumRodjenja = new DateTime(1991, 02, 15),
                Oib = "10293496392",
                redovanStudent = true
            });


            lista.Add(new Student()
            {
                ID = 2,
                Prezime = "Ivic",
                Ime = "Ivo",
                Spol = 'M',
                datumRodjenja = new DateTime(1994, 12, 3),
                Oib = "10030234215",
                redovanStudent = true
            });

            lista.Add(new Student()
            {
                ID = 3,
                Prezime = "Anic",
                Ime = "Ana",
                Spol = 'Z',
                datumRodjenja = new DateTime(1997, 08, 14),
                Oib = "39476018932",
                redovanStudent = false
            });

            lista.Add(new Student()
            {
                ID = 4,
                Prezime = "Marina",
                Ime = "Maric",
                Spol = 'Z',
                datumRodjenja = new DateTime(1995, 04, 04),
                Oib = "96034359800",
                redovanStudent = false
            });

        }
        public List<Student> vratiListu()
        {
            return lista;
        }
    }
    
}