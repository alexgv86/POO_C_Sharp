using System;

namespace PrimerBiblioteca
{
    public class PrimerClase
    {
        private string _nombreApellido;
        private int _edad;
        private double _altura;
        public PrimerClase() { }

        public PrimerClase(string nombreApellido,int edad,double altura)
        {
            NombreApellido = nombreApellido;
            _edad = edad/2;
            _altura = altura;
        }
        public string NombreApellido { get; set; }

        public double Altura
        {
            get { return _altura; }

            set { _altura = value; }
        }

        public int Edad {
            get { return _edad; }
            set { _edad = value; } 
        }

    }
}
