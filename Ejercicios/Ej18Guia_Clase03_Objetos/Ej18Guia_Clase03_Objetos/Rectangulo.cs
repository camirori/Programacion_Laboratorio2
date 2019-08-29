using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        //private Punto vertice2;
        private Punto vertice3;
        //private Punto vertice4;

        public float Area()
        {
            if(this.area==0)
            {
                float basE = Math.Abs(this.vertice1.GetX()- this.vertice3.GetX());
                float altura= Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.area = basE * altura;
            }                       
            return this.area;
        }

        public float Perimetro()
        {
            if(this.perimetro==0)
            {
                float basE = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.perimetro = (basE+altura)*2;
            }
            return this.perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3) //constructor
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            //this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
        }
    }
}
