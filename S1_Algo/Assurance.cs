using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class Assurance
    {
        public static void tarif()
        {
            int age;
            int yearsOfPermit;
            int nbrAccidents;
            int ageOfYearsOfEnsurance;
            int points = 0;

            Console.WriteLine("Entrez votre age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'années de permis : ");
            yearsOfPermit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'accidents : ");
            nbrAccidents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'années d'assurance : ");
            ageOfYearsOfEnsurance = Convert.ToInt32(Console.ReadLine());

            // tarif bleu, tarif vert, tarif orange, tarif rouge
            // age < ou > 25
            // nombre d'années de permis < ou > 2
            // nombre d'accidents 0, 1, 2

            if (ageOfYearsOfEnsurance >= 5)
            {
                points++;

                if (age >= 25)
                {
                    points++;
                }

                if (yearsOfPermit >= 2)
                {
                    points++;
                }

                if (nbrAccidents == 0)
                {
                    points++;
                }
                else if (nbrAccidents == 1)
                {
                    points--;
                }
            }
            else
            {
                if (age >= 25)
                {
                    points++;
                }

                if (yearsOfPermit >= 2)
                {
                    points++;
                }

                if (nbrAccidents == 0)
                {
                    points++;
                }
                else if (nbrAccidents >= 1)
                {
                    points--;
                }
            }

            if (points == 4)
            {
                Console.WriteLine("Tarif vert");
            }
            else if (points == 3)
            {
                Console.WriteLine("Tarif bleu");
            }
            else if (points == 2)
            {
                Console.WriteLine("Tarif orange");
            }
            else if (points == 1)
            {
                Console.WriteLine("Tarif rouge");
            }
            else
            {
                Console.WriteLine("Refusé");
            }

            //    if (age < 25)
            //    {
            //        if (yearsOfPermit < 2 && nbrAccidents == 0)
            //        {
            //            if (ageOfYearsOfEnsurance >= 5)
            //            {
            //                Console.WriteLine("Tarif orange");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tarif rouge");
            //            }
            //        }
            //        else if (yearsOfPermit >= 2)
            //        {
            //            if (nbrAccidents == 0)
            //            {

            //                if (ageOfYearsOfEnsurance >= 5)
            //                {
            //                    Console.WriteLine("Tarif vert");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Tarif orange");
            //                }
            //            }
            //            else if (nbrAccidents == 1)
            //            {
            //                if(ageOfYearsOfEnsurance >= 5)
            //                {
            //                    Console.WriteLine("Tarif orange");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Tarif rouge");
            //                }
            //            }
            //            else
            //            {
            //                Assurance.messageOfRefu();
            //            }
            //        }
            //        else
            //        {
            //            Assurance.messageOfRefu();
            //        }
            //    }
            //    else if (age >= 25)
            //    {
            //        if (yearsOfPermit >= 2 && nbrAccidents == 0)
            //        {
            //            Console.WriteLine("Tarif vert");
            //        }
            //        else if (yearsOfPermit >= 2 && nbrAccidents == 1)
            //        {
            //            if (ageOfYearsOfEnsurance >= 5)
            //            {
            //                Console.WriteLine("Tarif vert");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tarif orange");
            //            }
            //        }
            //        else if (yearsOfPermit >= 2 && nbrAccidents == 2)
            //        {

            //            if(ageOfYearsOfEnsurance >= 5)
            //            {
            //                Console.WriteLine("Tarif orange");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tarif rouge");
            //            }
            //        }
            //        else
            //        {
            //            Assurance.messageOfRefu();
            //        }
            //    }
            //}
            //private static void messageOfRefu()
            //{
            //    Console.WriteLine("Refusé");
            //}
        }
    }
}
