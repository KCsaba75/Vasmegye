using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // file olvasáa miatt kell.

namespace Vasmegye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: Adatok beolvasása tárolás");
            string vas = "vas.txt";
            StreamReader fvas= new StreamReader(vas);

            string[] tartalom= fvas.ReadToEnd().Split('\n');
            fvas.Close();
          


            bool ell;
           
            List<string> joszam = new List<string>();
           for(int i=0; i < tartalom.Length; i++) 
            {
                         
                string be = tartalom[i];
               
                CdvEll(be,out ell);
                   if (!ell) { 
                    Console.WriteLine($"Hibás a {be} személyi szám!");
                Console.ReadKey();
                }

                if (ell) { 
                    joszam.Add(be);
                Console.WriteLine($"jó a {be} személyi szám!");
               
                           }
                
                  
             }
           tartalom=joszam.ToArray();
            
        }

        static void CdvEll(string be, out bool ki)
        {
          

            if (be.Length != 13)
            {
                // Ha a bemeneti karakterlánc nem 13 karakter hosszú, hibás
                Console.WriteLine("Hibás karakterlánc hossz.");
                
            }

            char[] szemszam = be.ToCharArray();

            int[] szamok =new int[szemszam.Length];

            for (int i=0;i<szemszam.Length;i++)
            {
                if (int.TryParse(szemszam[i].ToString(), out int ezszam))
                {
                   szamok[i] = ezszam;

                }
                    


            }
          
            
                int matek = (szamok[0] * 10 + szamok[2] * 9 + szamok[3] * 8 + szamok[4] * 7 + szamok[5] * 6 +
                         szamok[6] * 5 + szamok[7] * 4 + szamok[9] * 3 + szamok[10] * 2 + szamok[11]) % 11;

                if (matek == szamok[12]) ki = true; else ki = false;
            
            

            // Matek
            
        }




    }
}
