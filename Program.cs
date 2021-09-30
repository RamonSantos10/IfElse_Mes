using System;
using static System.Console;

namespace IfElse_Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            int recalcular = 1;
            
            while (recalcular > 0 & recalcular < 2)
            {

                Write("Informe o número do mês do ano: ");
                mes = Convert.ToInt32(ReadLine());

                WriteLine("");

                if (mes == 1)
                {
                    WriteLine("Mês 01 -> Janeiro <- Com 31 dias");
                }
                else if (mes == 2)
                {
                    WriteLine("Mês 02 -> Fevereiro <- Normalmente com 28 dias e 29 dias em ano bissexto");
                }
                else if (mes == 3)
                {
                    WriteLine("Mês 03 -> Março <- Com 31 dias");
                }
                else if (mes == 4)
                {
                    WriteLine("Mês 04 -> Abril <- Com 30 dias");
                }
                else if (mes == 5)
                {
                    WriteLine("Mês 05 -> Maio <- Com 31 dias");
                }
                else if (mes == 6)
                {
                    WriteLine("Mês 06 -> Junho <- Com 30 dias");
                }
                else if (mes == 7)
                {
                    WriteLine("Mês 07 -> Julho <- Com 31 dias");
                }
                else if (mes == 8)
                {
                    WriteLine("Mês 08 -> Agosto <- Com 31 dias");
                }
                else if (mes == 9)
                {
                    WriteLine("Mês 09 -> Setembro <- Com 30 dias");
                }
                else if (mes == 10)
                {
                    WriteLine("Mês 10 -> Outubro <- Com 31 dias");
                }
                else if (mes == 11)
                {
                    WriteLine("Mês 11 -> Novembro <- Com 30 dias");
                }
                else if (mes == 12)
                {
                    WriteLine("Mês 12 -> Dezembro <- Com 31 dias");
                }
                else
                {
                    WriteLine("Mês inexistente !");
                }

                WriteLine("");

                Write("Para recalcular, digite 1. Para fechar, digite 2: ");
                recalcular = Convert.ToInt32(ReadLine());

                WriteLine("");
            }

            WriteLine("Obrigado por utilizar o programa !");

            WriteLine("");
        }
    }
}

        
    

