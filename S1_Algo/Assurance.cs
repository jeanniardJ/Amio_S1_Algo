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

            Console.WriteLine("Entrez votre age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'années de permis : ");
            yearsOfPermit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'accidents : ");
            nbrAccidents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'années d'assurance : ");
            ageOfYearsOfEnsurance = Convert.ToInt32(Console.ReadLine());

            //tarif vert, tarif bleu, tarif orange, tarif rouge

            if (age < 25)
            {
                if (yearsOfPermit < 2 && nbrAccidents == 0)
                {
                    if (ageOfYearsOfEnsurance >= 5)
                    {
                        Console.WriteLine("Tarif orange");
                    }
                    else
                    {
                        Console.WriteLine("Tarif rouge");
                    }
                }
                else if (yearsOfPermit >= 2)
                {
                    if (nbrAccidents == 0)
                    {

                        if (ageOfYearsOfEnsurance >= 5)
                        {
                            Console.WriteLine("Tarif vert");
                        }
                        else
                        {
                            Console.WriteLine("Tarif orange");
                        }
                    }
                    else if (nbrAccidents == 1)
                    {
                        if(ageOfYearsOfEnsurance >= 5)
                        {
                            Console.WriteLine("Tarif orange");
                        }
                        else
                        {
                            Console.WriteLine("Tarif rouge");
                        }
                    }
                    else
                    {
                        Assurance.messageOfRefu();
                    }
                }
                else
                {
                    Assurance.messageOfRefu();
                }
            }
            else if (age >= 25)
            {
                if (yearsOfPermit >= 2 && nbrAccidents == 0)
                {
                    Console.WriteLine("Tarif vert");
                }
                else if (yearsOfPermit >= 2 && nbrAccidents == 1)
                {
                    if (ageOfYearsOfEnsurance >= 5)
                    {
                        Console.WriteLine("Tarif vert");
                    }
                    else
                    {
                        Console.WriteLine("Tarif orange");
                    }
                }
                else if (yearsOfPermit >= 2 && nbrAccidents == 2)
                {

                    if(ageOfYearsOfEnsurance >= 5)
                    {
                        Console.WriteLine("Tarif orange");
                    }
                    else
                    {
                        Console.WriteLine("Tarif rouge");
                    }
                }
                else
                {
                    Assurance.messageOfRefu();
                }
            }
        }
        private static void messageOfRefu()
        {
            Console.WriteLine("Refusé");
        }
    }
}
