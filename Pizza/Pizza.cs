using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Pizza
    {
        string pizzaNev;
        double ar;
        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            pizzaNev = sor[0];
            ar = double.Parse(sor[1].Trim().Replace('.', ','));
        }
        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }
        public double Ar { get => ar; set => ar = value; }
        public override string ToString()
        {
            return $"{pizzaNev} ára: {ar.ToString("#,##0.0")}";
        }
    }
}
