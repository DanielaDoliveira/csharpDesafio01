using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Inputs.User.Interface;

namespace Desafio.Inputs.Math
{
    public class InputCalculator
    {
        double value1, value2;

        Calculator calculator = new Calculator();
        public void Execute()
        {

            Console.Clear();
            Console.WriteLine("Bem vindo! Para começar, digite uma opcao: ");
            Loading.LoadingBetweenInstructions();
            Console.WriteLine("\n S para Soma:\n SUB para Subtracao:\n M para Multiplicacao:\n D para Divisao:\n ");
            string _option = Console.ReadLine();
            var upper = _option.ToUpper();
            Loading.LoadingBetweenInstructions();
            OptionsMenu(upper, calculator);
        }
        public void OptionsMenu(string option, Calculator calculator)
        {


            switch (option)
            {
                case "S":
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Loading.LoadingBetweenInstructions();
                        Console.WriteLine("Agora digite o segundo numero: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        var sum = calculator.Sum(n1, n2);
                        Console.WriteLine("A soma eh: {0}", sum);

                    }
                    break;
                case "SUB":
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Loading.LoadingBetweenInstructions();
                        Console.WriteLine("Agora digite o segundo numero: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        var sub = calculator.Subtraction(n1, n2);
                        Console.WriteLine("A subtracao eh: {0}", sub);
                    }
                    break;
                case "M":
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Loading.LoadingBetweenInstructions();
                        Console.WriteLine("Agora digite o segundo numero: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        var m = calculator.Multiply(n1, n2);
                        Console.WriteLine("A multiplicacao eh: {0}", m);
                    }
                    break;
                case "D":
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Loading.LoadingBetweenInstructions();
                        Console.WriteLine("Agora digite o segundo numero: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        var d = calculator.Divide(n1, n2);
                        Console.WriteLine("A divisão eh: {0}", d);
                    }
                    break;
                default:
                    {
                        throw new Exception("----OPCAO NAO ENCONTRADA------");
                    }
                    break;

            }

        }



    }
}