using System.Diagnostics.Tracing;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            Console.WriteLine(Anagram(str, "star"));
        }

        public static string Anagram(string x, string check) 
        {
            string[] words = x.Split(',');
            string result = "";
            foreach (string word in words)
            {
                if(AnagramChecker(word, check))
                {
                    if(result == "")
                    {
                        result += word;
                    }
                    else
                    {
                        result += ", " + word;
                    }
                    
                }
                
            }

            return result;
        }

        public static bool AnagramChecker(string a, string b) 
        {
            if(a.Length !=  b.Length) { return false; }
            if(a == b) { return true; }
            // Order by char then check if resultant sequence is the same
            string aa = String.Concat(a.OrderBy(c  => c));
            string bb = String.Concat(b.OrderBy(c => c));
            if (aa == bb) { return true; }
            else { return false; }
        }
    }
}
