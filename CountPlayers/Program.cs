using System;

public class Program
{
    private static List<string> players = new List<string>();   //многомерный массив строк
    
    public static void Main()
    {
        var number = Convert.ToInt32(Console.ReadLine());
        Input(number);
        Console.WriteLine(players.Count);
    }

    public static void Input(int number)    //методля для считывания с циклом
    {
        while (number > 0)
        {
            MakeListOfPlayers();
            number--;
        }
    }
    
    public static void MakeListOfPlayers()     //добаление игрока в массив
    {
        var nickname = Console.ReadLine();
        if (!Search(nickname))
        {
            players.Add(nickname);
        }
    }

    public static bool Search(string name)      //проверка, если игрок уже есть в спискке
    {
        string tempName = name;

        for (var i = 0; i < players.Count; i++)
        {
            if (tempName.Equals(players[i]))
            {
                return true;
            }
        }
        return false;
    }
}