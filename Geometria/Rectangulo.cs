using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float _area;
        private float _perimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;
        
        static bool calculoRealizado;

        static Rectangulo()
        {
            calculoRealizado = false;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            _vertice1 = vertice1;
            _vertice3 = vertice3;

            _vertice2 = new Punto(vertice1.X, vertice3.Y);
            _vertice4 = new Punto(vertice3.X, vertice1.Y);
        }
        
        public float Area
        {
            get 
            { 
                if (!calculoRealizado)
                {
                    _area = Math.Abs(_vertice3.X - _vertice1.X) * Math.Abs(_vertice2.Y - _vertice1.Y);
                }
                return _area; 
            }
        }

        public float Perimetro
        {
            get 
            { 
                if (!calculoRealizado)
                {
                    _perimetro = (Math.Abs(_vertice3.X - _vertice1.X) + Math.Abs(_vertice4.Y - _vertice3.Y)) * 2;
                }
                return _perimetro; 
            }
        }
    }
}