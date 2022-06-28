using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBoJaJuzNieWiem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz zbiór znaków.");

            string slowo = Console.ReadLine();

            char[] znaki = slowo.ToCharArray();

            char[] pusteZnaki = null;

            for (int i = 0; i < znaki.Length; i++ )
            {
                petlaFor(i+1, 0, znaki.Length - i, 0, znaki, pusteZnaki);
            }
            //petlaFor(znaki.Length - 3, 0, znaki.Length - 0, 0, znaki, pusteZnaki);
            //petlaFor(znaki.Length - 2, 0, znaki.Length - 1, 0, znaki, pusteZnaki);
            //petlaFor(znaki.Length - 1, 0, znaki.Length - 2, 0, znaki, pusteZnaki); 3 element - the biggest i = 2


            Console.ReadKey();
        }

        static void petlaFor(int minus, int I, int ilePetli, int ilePetliDone, char[] znaki, char[] pusteZnaki)
        {
            if( ilePetliDone == 0)
                pusteZnaki = new char[ilePetli];
              
            for (int i = I; i < znaki.Length - minus; i++)
            {
                pusteZnaki[ilePetliDone] = znaki[i];
                //pusteZnaki.add(znaki[i]);
                ilePetliDone++;
                if (ilePetli > ilePetliDone)
                {
                    i++;
                    minus--;
                    petlaFor(minus, i, ilePetli, ilePetliDone, znaki, pusteZnaki);
                }
                else
                {
                    minus = znaki.Length - 2;
                    Console.WriteLine(pusteZnaki);
                    ilePetliDone--;
                    
                }
                
            }

        }
    }
}
