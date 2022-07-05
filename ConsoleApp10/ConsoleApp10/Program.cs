using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cesio
{
    class Program
    {
        static void Main(string[] args)
        {
            int ss = 1, shift = 1;

            Console.WriteLine("введите номер нужного вам языка \n1.Русский \n2.Английский");
            int lang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите слово,которое нужно зашифровать/расшифровать:");
            string var = Console.ReadLine();

            Console.WriteLine("Введите позицию сдвига:");
            shift = Convert.ToInt32(Console.ReadLine());

            string var1 = "";

           

            
            if (lang == 1)
            {

                string alfphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                string fullAlfabet = alfphabet + alfphabet.ToUpper();


                int m = fullAlfabet.Length; 

                for (int i = 0; i < var.Length; i++)
                {
                    for (int j = 0; j < fullAlfabet.Length; j++)
                    {
                        if (var[i] == fullAlfabet[j])
                        {
                            int temp = j * ss + shift;

                            while (temp >= m)
                                temp -= m;

                            var1 = var1 + fullAlfabet[temp];
                        }
                    }

                }
            }
            else if (lang == 2)
            {

                string alfphabet = "abcdefghijklmnopqrstuvwxyz";
                string fullAlfabet = alfphabet + alfphabet.ToUpper();


                int m = fullAlfabet.Length; 

                for (int i = 0; i < var.Length; i++)
                {
                    for (int j = 0; j < fullAlfabet.Length; j++)
                    {
                        if (var[i] == fullAlfabet[j]) 
                        {
                            int temp = j * ss + shift;

                            while (temp >= m)
                                temp -= m;

                            var1 = var1 + fullAlfabet[temp];
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("НЕВЕРНОЕ ЧИСЛО,ПРИ ВЫБОРЕ ЯЗЫКА!");
            }

            Console.WriteLine("изменённое слово:" + var1);
            Console.ReadLine();
        }    
    }
}

