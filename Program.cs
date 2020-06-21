using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMystereConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomed = new Random().Next(20) + 1;

            NouvellePartie(randomed);

            YouWin(randomed);

            Console.ReadKey();
        }
        static void NouvellePartie(int randomed)
        {
            Console.WriteLine("Saisissez un nombre entre 0 et 20: ");
            int pickedNum = PickANumber();

            while (pickedNum != randomed)
            {
                if (pickedNum > randomed)
                {
                    Console.WriteLine("C'est moins! ");
                }

                else
                {
                    Console.WriteLine("C'est plus!");
                }
                pickedNum = PickANumber();
            }
        }


        static void YouWin(int randomed)
        {
            Console.WriteLine("Bravo ! Vous avez trouvez le nombre mystère : " + randomed);
        }

            static int PickANumber()
        {
            string picked = Console.ReadLine();

            int pickedNum;

            while (int.TryParse(picked, out pickedNum) == false)
            {
                Console.WriteLine("Oops Il ne s'agit pas d'un nombre. Essaie encore.");
                picked = Console.ReadLine();
            }
            return pickedNum;

            
        }

    }
}

