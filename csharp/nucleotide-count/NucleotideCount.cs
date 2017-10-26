using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    private Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>
    {
        { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 }
    };

    private string validNucleotides = "ACGT";
    public NucleotideCount(string sequence)
    {
        foreach(char c in sequence)
        {
            if(!validNucleotides.Contains(c.ToString()))
            {
                throw new InvalidNucleotideException();
            }
        }
        nucleotideCounts['A'] = sequence.Count(c => c == 'A');
        nucleotideCounts['C'] = sequence.Count(c => c == 'C');
        nucleotideCounts['G'] = sequence.Count(c => c == 'G');
        nucleotideCounts['T'] = sequence.Count(c => c == 'T');
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return this.nucleotideCounts;
        }
    }
}
    public class InvalidNucleotideException : Exception {
    public InvalidNucleotideException() { }
}

