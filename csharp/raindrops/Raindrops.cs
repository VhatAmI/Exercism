using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string result = "";
        if(number%3 == 0)
        {
            result = result + "Pling";
        }
        if (number % 5 == 0)
        {
            result = result + "Plang";
        }
        if (number % 7 == 0)
        {
            result = result + "Plong";
        }

        if(result.Length == 0) { return number.ToString();  }

        return result;

    }
}