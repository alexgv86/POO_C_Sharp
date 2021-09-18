using System;
using PrimerBiblioteca;

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
        }
    }
}
