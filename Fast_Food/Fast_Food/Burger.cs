using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
    class Burger
    {
        private string beef;

        public string Beef
        {
            get { return beef; }
            set { beef = value; }
        }

        private string buns;

        public string Buns
        {
            get { return buns; }
            set { buns = value; }
        }

        private string salad;

        public string Salad
        {
            get { return salad; }
            set { salad = value; }
        }

        public Burger(string beef, string buns, string salad)
        {
            Beef = beef;
            Buns = buns;
            Salad = salad;
        }
    }
}
