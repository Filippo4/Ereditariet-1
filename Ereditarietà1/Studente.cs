using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà1
{
    class Studente : Persona
    {
        public string classe { get; private set; }
        public Studente(string n , string c , double a  , DateTime dda,string classe) : base(n, c, a, dda)
        {
            nome = n;
            cognome = c;
            datadinascita = dda;
            altezza = a;
            this.classe = classe;
        }
    }
}
