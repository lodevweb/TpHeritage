using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpHeritage
{
    public class Rectangle : Forme
    {
        public virtual int Largeur { get; set; }
        public int Longueur { get; set; }
       
        public override double Aire => Largeur + Longueur;

    }
}
