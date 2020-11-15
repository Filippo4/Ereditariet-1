using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà1
{
    class Docente : Lavoratore
    {
        public string classe { get; private set; }
        public string materia { get; private set; }
        public Docente(string n, string c, DateTime dda, double a, double s, string classe, string m) : base(n, c, dda, a, s)
        {
            nome = n;
            cognome = c;
            datadinascita = dda;
            altezza = a;
            stipendio = s;
            this.classe = classe;
            materia = m;
        }
    }
}
