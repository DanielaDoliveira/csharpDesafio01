using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Exceptions;

namespace Desafio.Inputs.CharCount
{
    public class InputCountChar
    {
        private string inputText, removeWhiteSpace;
        private int result, resultWithoutWhiteSpace;

        public void Execute()
        {
            string message = "Este programa conta quantos caracteres voce digitou.\n Digite abaixo algum caractere:\n";
            string obs = "\nCaracteres podem ser letras,numeros,caracteres especiais e ate mesmo o espaco em branco";
            Console.WriteLine(message);
            Console.WriteLine(obs);
            inputText = Console.ReadLine();
            result = inputText.Length;
            removeWhiteSpace = inputText.Replace(" ", "");
            resultWithoutWhiteSpace = removeWhiteSpace.Length;

            ValidateInput(inputText, result, resultWithoutWhiteSpace);

        }
        public void ValidateInput(string _inputText, int _result, int _resultWithoutWhiteSpace)
        {

            if (string.IsNullOrEmpty(_inputText))
                throw new ValidationErrorException("---ENTRADA DE TEXTO INVALIDA. EH NECESSARIO DIGITAR PELO MENOS UM CATACTERE!----");
            else
                RunApplication(_result, _resultWithoutWhiteSpace);

        }
        public void RunApplication(int _result, int _resultWithoutWhiteSpace)
        {
            Console.WriteLine("Sua palavra tem {0} caracteres contando com os espacos em branco", _result);

            Console.WriteLine("Sem contar os espacos em branco, sua palavra tem {0} caracteres", _resultWithoutWhiteSpace);
            Loading.LoadingFinishProgram();
        }

    }
}