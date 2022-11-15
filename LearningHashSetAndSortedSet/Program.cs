/*Problema exemplo
Um site de internet registra um log de acessos dos usuários. Umregistro de log consiste no nome de usuário e o instante em que ousuário acessou o site no padrão ISO 8601,
separados por espaço, conforme exemplo. Fazer um programa que leia o log de acessos apartir de um arquivo, e daí informe quantos usuários distintosacessaram o site.
*/


using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using LearningHashSetAndSortedSet.Entities;

namespace LearningHashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> Set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string Path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] Archive = sr.ReadLine().Split(' ');

                        string name = Archive[0];
                        DateTime instant = DateTime.Parse(Archive[1]);

                        Set.Add(new LogRecord(name, instant));

                    }

                    Console.Write("Total users: " + Set.Count);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
