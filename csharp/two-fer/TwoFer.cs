using System;

  public static class TwoFer
  {
      public static string Name(string input = null)
      {
        string name = "you";

        if(input != null)
        {
            name = input; 
        }

        return "One for " + name + ", one for me.";
      }
  }
