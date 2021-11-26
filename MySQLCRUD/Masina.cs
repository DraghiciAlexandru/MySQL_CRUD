using System;
using System.Collections.Generic;
using System.Text;

namespace MySQLCRUD
{
    class Masina
    {
        private int id;
        private String model;
        private int an;
        private String culoare;

        public int ID
        {
            get { return id; }
        }
        public String Model
        {
            get { return model; }
        }
        public int An
        {
            get { return an; }
        }
        public String Culoare
        {
            get { return culoare; }
        }

        public Masina(int id, String model, int an, String culoare)
        {
            this.id = id;
            this.model = model;
            this.an = an;
            this.culoare = culoare;
        }

    }
}
