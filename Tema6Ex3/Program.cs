using System;

namespace Tema6Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] note1 = { 2, 3, 5, 7, 9, 8 };
            int[] note2 = {2, 8, 5, 1, 7, 8};
            int[] note3 = { 9, 8, 5, 10, 9, 8 };

            Elev elev1 = new Elev("Ioan", "Pop", note1);
            Elev elev2 = new Elev("Gergo", "Antal", note2);
            Elev elev3 = new Elev("Krisztian", "Matis", note3);

            Elev[] elevii = new Elev[] { elev1, elev2, elev3 };

            Catalog catalog = new Catalog("10B ", elevii);

            Console.WriteLine(" Lista elevilor: ");
            catalog.Tipareste();

            Console.WriteLine("Elevul premiant: ");
            catalog.GetPremiantul().Tipareste();

        }
    }
}
