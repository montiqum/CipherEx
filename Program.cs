using System;

namespace CipherEx
{
    class Program
    {
        static string input = "";
        static int key = 0;
        public static void Encrypt()
        {
            Console.WriteLine("Input Message to encrypt.");
            input = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the no.of places");
            key = Int32.Parse(Console.ReadLine());
            char[] mystring = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    mystring[i] = ' ';
                }
                else
                {
                    mystring[i] = (char)(Convert.ToInt32(input[i]) - key);
                    if(mystring[i] < 65)
                    {
                        mystring[i] = (char)(mystring[i] + 26);
                    }
                    if (mystring[i] > 90)
                    {
                        mystring[i] = (char)(mystring[i] - 26);
                    }
                }

                Console.Write($"{mystring[i]}");
            }

        }
        static void Main(string[] args)
        {
            Encrypt();
        }
    }
}
