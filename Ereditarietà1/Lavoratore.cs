using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà1
{
    class Lavoratore : Persona
    {
        public double stipendio { get; set; }
        public Lavoratore (string n , string c , DateTime dda, double a , double s ):base(n,c,a,dda)
        {
            nome = n;
            cognome = c;
            datadinascita = dda;
            altezza = a;
            stipendio = s;
        }
    }
}
