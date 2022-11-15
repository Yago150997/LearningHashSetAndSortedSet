/*Problema exemplo
Um site de internet registra um log de acessos dos usuários. Umregistro de log consiste no nome de usuário e o instante em que ousuário acessou o site no padrão ISO 8601,
separados por espaço, conforme exemplo. Fazer um programa que leia o log de acessos apartir de um arquivo, e daí informe quantos usuários distintosacessaram o site.
*/


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace LearningHashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path");
            string Path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {


                    while (!sr.EndOfStream)
                    {
                        string Archive = sr.ReadLine();
                        Console.WriteLine(Archive);

                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
