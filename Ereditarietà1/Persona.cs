using System;

namespace Ereditarietà1
{
    public class Persona
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public double altezza { get; set; }
        public DateTime datadinascita { get; set; }
        public Persona( string n, string c , double a, DateTime dda)
        {
            nome = n;
            cognome = c;
            altezza = a;
            datadinascita = dda;
        }

    }
}
