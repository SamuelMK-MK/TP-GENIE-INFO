using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionPersonneLib
{
    class Adresse:IAdresse
    {
        public Adresse() { 
        }

        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }
        private string Nom;

        public string Nom1
        {
            get { return Nom; }
            set { Nom = value; }
        }
        private string Postnom;

        public string Postnom1
        {
            get { return Postnom; }
            set { Postnom = value; }
        }
        private string Adresse;

        public string Adresse1
        {
            get { return Adresse; }
            set { Adresse = value; }
        }
    }
}
