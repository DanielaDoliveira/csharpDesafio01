
using Desafio.Inputs.User;

namespace Desafio;

class Program
{
  static void Main()
  {
    //Retorna apenas o nome
    #region Exercicio1
    InputName inputName = new InputName();
    inputName.UserInputs();
    #endregion

    LoadBetweenActivities();
    Console.WriteLine("\n ... Exercício 2 ... \n");
    LoadBetweenActivities();

    //Retorna Nome e Sobrenome
    #region Exercicio2


    InputUser inputUser = new InputUser();
    inputUser.UserInputs();
    #endregion


    void LoadBetweenActivities()
    {
      Thread.Sleep(2000);
      Console.Clear();
    }

  }

}