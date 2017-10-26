using System;
using System.Linq;
using System.Collections.Generic;

public class School
{
    public void Add(string student, int grade)
    {
        if (!roster.ContainsKey(grade))
        {
            roster[grade] = new List<string>();
        }
        roster[grade].Add(student);
        roster[grade].Sort();

    }
    public Dictionary<int, List<string>> roster = new Dictionary<int, List<string>> { };

    public string[] Roster()
    {
        List<string> result = new List<string>();

        var sortedDic = from key in roster.Keys
                        orderby key ascending
                        select key;

        foreach ( var key in sortedDic)
        {
            result.AddRange(roster[key]);
        }
        return result.ToArray();
    }
    public List<string> Grade(int grade)
    {
        if (!roster.ContainsKey(grade))
            return new List<string>();
        roster[grade].Sort();
        return roster[grade];
    }
}