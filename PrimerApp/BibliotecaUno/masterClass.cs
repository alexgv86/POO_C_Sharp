using System;

namespace BibliotecaUno
{
    public class masterClass
    {
        private int _id;
        private double _ancho;
        private double _largo;
        private double _superficie;
        private string _nombre;

        public masterClass()
        {
            _id = 0;
            _ancho = _largo = _superficie = 0;
            _nombre = string.Empty;
        }

        public masterClass(int id, double ancho, double largo, string nombre)
        {
            _id = id;
            _ancho = ancho;
            _largo = largo;
            _superficie = ancho * largo;
            _nombre = nombre;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public double Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }
        public double Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }
        public double Superficie
        {
            get { return _superficie; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double CalcularSuperficie()
        {
            double resultado;
            resultado = _largo * _ancho;
            return resultado;
        }
    }
}
