using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (statement.Length == 0)
        {
            return "Fine. Be that way!";
        }
        if (statement.ToUpper() == statement && statement.ToLower() != statement)
        {
            return "Whoa, chill out!";
        }     
        if(statement[statement.Length-1] == '?')
        {
            return "Sure.";
        }
        return "Whatever.";
    }
}