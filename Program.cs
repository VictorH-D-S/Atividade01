using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01_Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Conrado Hartwell White";
            string nome2 = "Gus Fring";
            

            int idade1 = 16;
            int idade2 = 65;
            int cafe1 = 187;
            int cafe2 = 22;
            int total_de_cafes = cafe2 + cafe1;
            int de200 =  200 - cafe1;
            int de200_2 = 200 - cafe2;
            

            bool ehcliente = true;
            bool naoehcliente = false;
           

            Console.WriteLine("Olá!");
            Console.WriteLine("Bem-Vindo ao sistema de usuário do Conrado");
            Console.WriteLine("Informações de usuários cadastrados abaixo:\n \n");


            Console.WriteLine("--------Lista de usuários: \n");
            Console.WriteLine($"1 - Nome: {nome1}, Idade: {idade1}. É cliente: {ehcliente} ");
            Console.WriteLine($"2 - Nome: {nome2}, Idade: {idade2}. É cliente: {naoehcliente}\n\n");

            Console.WriteLine("-------- Cafés Tomados:\n");
            Console.WriteLine($"O cliente {nome1} tomou {cafe1} cafés até agora!");
            Console.WriteLine($"O cliente {nome2} tomou {cafe2} cafés até agora!\n \n");

            Console.WriteLine("--------- Total de Cafés Tomados:\n");
            Console.WriteLine($"Juntos, os clientes {nome1} e {nome2} tomaram {total_de_cafes} cafés!\n\n");

            Console.WriteLine("---------Quantos cafés faltam para os clientes chegarem em 200 café tomados?:\n");
            Console.WriteLine($"Faltam {de200} para {nome1}.");
            Console.WriteLine($"Faltam {de200_2} para {nome2}");

            Console.WriteLine("\n\n--------- Fim do Sistema de consultas. \n Obrigado e volte sempre!");

            Console.ReadKey();
        } 
    }
}
