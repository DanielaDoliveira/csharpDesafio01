
using System.Security.Cryptography.X509Certificates;
using Desafio.Inputs.Math;
using Desafio.Inputs.User;

namespace Desafio;

class Program
{
  static void Main()
  {

    // Variáveis booleanas de exercícios
    bool ativarExercicio1 = false;
    bool ativarExercicio2 = false;
    bool ativarExercicio3 = false;
    List<bool> exercicio = new List<bool>();
    //


    DevelopmentSettings();



    #region Exercicio1
    if (ativarExercicio1)
    {
      InputName inputName = new InputName();
      inputName.UserInputs();
    }
    #endregion

    //Retorna Nome e Sobrenome
    #region Exercicio2
    if (ativarExercicio2)
    {
      Loading.LoadBetweenActivities();

      Console.WriteLine("\n ... Exercício 2 ... \n");
      Loading.LoadBetweenActivities();
      InputUser inputUser = new InputUser();
      inputUser.UserInputs();
    }


    #endregion


    //Retorna apenas o nome

    //Cálculos
    #region Exercicio3
    if (ativarExercicio3)
    {
      Loading.LoadBetweenActivities();
      Console.WriteLine("\n ... Exercício 3 ... \n");
      InputCalculator inputCalculator = new InputCalculator();
      inputCalculator.Execute();
    }
    #endregion

    void DevelopmentSettings()
    {
      exercicio.Add(ativarExercicio1);
      exercicio.Add(ativarExercicio2);
      exercicio.Add(ativarExercicio3);

      if (exercicio.Contains(true)) { }
      else
      {
        Console.WriteLine("Para ver os resultados deste programa, ative uma das variaveis booleanas de exercicio");

      }


    }
  }

}