using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp.Lessons3
{
    internal class Program
    {

        static void Exmpl01()
        {
            int[] arr = new int[5];
            arr[0] = 55;


            int[] arr2 = new int[] { 1, 3, 4 };
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = i;
            }
            FillArray(arr);
        }
        static void FillArray(int[] arr)
        {
            Random rnd = new Random();//get
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
        }
        static void PrinArrayHorizont(int[] arr)
        {
            for(int i=0; i<arr.Length ; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("");
        }
        static void PrinArrayVertical(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)//get
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("");
        }

        static void Exmpl02()
        {
            Random rand = new Random(); 
            int[,] arr= new int[5, 5];
            for(int i=0; i < 5; i++)
            {
                for(int j=0; j < 5; j++)
                {
                    arr[i,j] = rand.Next(1, 100);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine("");
            }


        }

        /// <summary>
        /// 2.	Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий 
        /// массив общие элементы первых двух массивов без повторений. 
        /// </summary>
        static void Exmpl03(int[] arr1, int[] arr2)
        {
            int len1=arr1.Length;
            int len2=arr2.Length;   
            int[] arr3 = new int[len1+len2];
            for(int i=0; i<arr1.Length; i++)
            {
                arr3[i] = arr1[i];
                Console.Write(arr3[i]+" ");
            }
            Console.WriteLine("");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[len1+i] = arr2[i];
                Console.Write(arr3[len1+i]+" ");
            }
            int len=len1+len2;

            for (int l=0; l<len; l++)
            {
                for(int i = l+1; i<len; i++)
                {
                    if (arr3[l] == arr3[i])
                    {
                        int len3 = len;
                        int[] arr=new int[len3-1];

                        for(int j=0; j<i; j++)
                        {
                            arr[j] = arr3[j];                           
                        }
                        for(int k=i+1; k<len3; k++)
                        {
                            arr[k-1] = arr3[k];
                        }
                        i--;
                        len--;
                        arr3 = arr;
                    }
                }

                
            }
            Console.WriteLine("");
            PrinArrayHorizont(arr3);





        }

        /// <summary>
        /// 5.	Дан двумерный массив размерностью 5×5, заполненный случайными числами 
        /// из диапазона от –100 до 100. Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
        /// </summary>
        static void Exmpl04(int[,] arr)
        {
            Random rnd = new Random();//get
            int max, min;
            max = -100;
            min= 100; 
            int inx, iny;
            int inxmin, inymin;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                    if(arr[i, j] > max)
                    {
                        max = arr[i, j];
                        inx = i;
                        inx = j;
                    }
                    if (arr[i, j] < min) 
                    { 
                        inxmin = i;
                        inymin = j;
                        min = arr[i, j];
                    }
                } 
            }
        }

        /// <summary>
        /// 3. Пользователь вводит строку. Проверить, является ли эта строка палиндромом. 
        /// Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
        /// </summary>
        static void Exmpl05(string str)
        {
            int lenstr=str.Length;
            if(str == null)
            {
                Console.WriteLine("Эта строка не являеться палиндромом");
            }else
            {
                int num = 0;
                for(int i=0; i< lenstr/2+1; i++)
                {
                    if (str[i] == str[lenstr - i - 1])
                    {
                        num++;
                    }
                }
                if(num == lenstr / 2 + 1)
                {
                    Console.WriteLine("Эта строка являеться палиндромом");
                }
                else
                {
                    Console.WriteLine("Эта строка не являеться палиндромом");
                }
            }
        }

        /// <summary>
        /// 4. Подсчитать количество слов во введенном предложении.
        /// </summary>
        static void Exmpl06(string str)
        {
            char[] separators = { ' ' };
            string[] parts = str.Split(separators, StringSplitOptions.None);
            Console.WriteLine(parts.Length);
        }

        /// <summary>
        /// 9.	Дан текст, состоящий из 20 букв. Проверить, можно ли из заданной последовательности
        /// символов составить Ваше имя и напечатать его. В противном случае напечатать текст “Нет имени”.
        /// </summary>
        static void Exmpl07(string str, string name)
        {
            int n = 0;
            bool noname=true;
            for(int i=0; i < str.Length; i++)
            {
                if (str[i] == name[n])
                {
                    n++;
                }
                if (n == name.Length)
                {
                    Console.WriteLine(name);
                    noname = false;
                    break;
                }
            }
            if (noname)
            {
                Console.WriteLine("Нет имени");
            }

        }
        /// <summary>
        /// 6.	Дан текст. Найти наибольшее количество идущих подряд одинаковых символов
        /// </summary>
        static void Exmpl08(string text)
        {
            int maxConsecutiveCount = FindMaxConsecutiveCount(text);
            Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов: {maxConsecutiveCount}");
        }
        static int FindMaxConsecutiveCount(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            int currentCount = 1;
            int maxCount = 1; 

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                    currentCount = 1;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }





        static void Main(string[] args)
        {
            /*  int[] arr=new int[5];
              FillArray(arr);
              Console.WriteLine("___");
              PrinArrayHorizont(arr);
              Console.WriteLine("___");
              PrinArrayVertical(arr);*/
            /* Exmpl02();*/
            /* int[] arr1 = new int[] { 1, 5, 1, 5 };
             int[] arr2 = new int[] { 5, 1, 6, 6 ,6 };
             Exmpl03(arr1, arr2);*/

            /* Console.WriteLine("Введите строку: ");
             string str=Convert.ToString(Console.ReadLine());
             Exmpl05(str);*/
           /* string str = "irjgndrigvnOrazbay";
            string name = "Orazbay";
            //Exmpl06(str);
            Exmpl07(str, name);*/

            string text = "rettyuyddd";
            Exmpl08(text);
        }
    }
}
