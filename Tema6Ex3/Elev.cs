using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6Ex3
{

    class Elev
    {
        private string nume;
        private string prenume;
        private int[] note;

        public Elev(string nume, string prenume, int[] note)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.note = note;
        }

        public double Media()
        {
            double aux = 0; 
            for (int i = 0; i < note.Length; i++)
            {
                aux += note[i];
                
            }

            aux = aux / note.Length;
            return aux;
        }

        public void Tipareste()
        {
            Console.WriteLine(nume + " " + prenume);
            for (int i = 0; i < note.Length; i++)
            {
                Console.Write(note[i] + " ");
            }

        }
            


    }
}
