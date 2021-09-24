using System;
using PrimerBiblioteca;
using BibliotecaUno;

namespace PrimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimerClase pc2 = new PrimerClase ("Alejandro Saavedra", 35, 1.7 );
            PrimerClase pc = new PrimerClase();
            pc.NombreApellido = "Alejandro González Videla";
            pc.Edad = 35;
            pc.Altura = 1.89;

            Console.WriteLine($"PC = {pc.NombreApellido} {pc.Edad} {pc.Altura}");
            Console.WriteLine($"PC = {pc2.NombreApellido} {pc2.Edad} {pc2.Altura}");

            masterClass mc = new masterClass();
            masterClass mc1 = new masterClass(1, 2, 3, "Cuadrado");
            Console.WriteLine(mc.Id);
            Console.WriteLine(mc.Ancho);
            Console.WriteLine(mc.Largo);
            Console.WriteLine(mc.Superficie);
            Console.WriteLine(mc.Nombre);

            Console.WriteLine(mc1.Id);
            Console.WriteLine(mc1.Ancho);
            Console.WriteLine(mc1.Largo);
            Console.WriteLine(mc1.Superficie);
            Console.WriteLine(mc1.Nombre);
        }
    }
}
