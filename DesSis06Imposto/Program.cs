using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis06Imposto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva a Forma de contratação que deseja calcular o salário:{ (A)ssalariado, (C)omissionado, (H)orista}");
             string contratacao = Console.ReadLine();
            double sal = 0;
            switch (contratacao)
            {
                case "A":
                    Console.WriteLine("Digite o valor do salário bruto: ");
                    double salBr = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do desconto: ");
                    double desc = double.Parse(Console.ReadLine());
                    sal = salBr - desc;
                    Console.WriteLine("o valor do salário é de: " + sal);
                    break;

                case "C":
                    Console.WriteLine("Digite a quantidade de peças vendidas : ");
                    double qtdPec = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor por peças : ");
                    double valpec = double.Parse(Console.ReadLine());
                    sal = qtdPec * valpec;
                    Console.WriteLine("o valor do salário é de: " + sal);
                    break;

                case "H":
                    Console.WriteLine("Digite a quantidade de horas trabalhadas : ");
                    double hr = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor por Hora : ");
                    double valhr = double.Parse(Console.ReadLine());
                    sal = valhr * hr;
                    Console.WriteLine("o valor do salário é de: " + sal);
                    break;
            }

            //calculo do imposto de renda 
            double IR = 0;

            if (sal <= 2000)
            {
                IR = sal * 0.075;
                Console.WriteLine("O Valor do Imposto de Renda é de: " + IR);
            }
            else if (sal <= 4000)
            {
                IR = sal * 0.12;
                Console.WriteLine("O Valor do Imposto de Renda é de: " + IR);
            }
            else if (sal > 5000)
            {
                IR = sal * 0.15;
                Console.WriteLine("O Valor do Imposto de Renda é de: " + IR);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }



            Console.ReadKey();
        }
    }
}
