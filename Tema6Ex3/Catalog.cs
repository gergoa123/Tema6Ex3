using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6Ex3
{
    class Catalog
    {
        string numeClasa;
        Elev[] elevi;

        public Catalog(string numeClasa, Elev[] elevi)
        {
            this.numeClasa = numeClasa;
            this.elevi = elevi;
        }

        public void Tipareste()
        {
            Console.WriteLine(numeClasa);
            for (int i = 0; i < elevi.Length; i++)
            {
                elevi[i].Tipareste();
                Console.WriteLine();
            }
        }

        public Elev GetPremiantul()
        {
            double maxim = elevi[0].Media();
            Elev premiant = elevi[0];

            for (int i = 1; i < elevi.Length; i++)
            {
                if ( maxim < elevi[i].Media())
                {
                    maxim = elevi[i].Media();
                    premiant = elevi[i];
                }
            }

            return premiant;
        }
    }
}
