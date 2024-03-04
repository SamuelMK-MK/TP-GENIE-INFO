using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionPersonneLib
{
    interface IAdresse
    {
        int Id { get; set; }       
        string Nom { get; set; }
        string Postnom { get; set; }
        string Adresse { get; set; }
    }
}
