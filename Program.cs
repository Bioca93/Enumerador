using System;

namespace EnumEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Enums
            string segunda = "Segunda-Feira";

            int diaSemana = (int)DiasSemana.Segunda;

            Console.WriteLine(diaSemana);
            Console.WriteLine((DiasSemana)4);
            Console.WriteLine(DiasSemana.Segunda);

            Console.WriteLine(segunda);
            Console.WriteLine("Segunda-Feira");
            Console.WriteLine("Segunda-Feira");
        }
    }

    public enum DiasSemana
    {
        Segunda = 1,
        TercaFeira = 2, // Terça-Feira
        QuartaFeira = 3,
        QuintaFeira = 4,
        SextaFeira = 5,
        Sabado = 6,
        Domingo = 7,
        DiaXpto
    }
}
