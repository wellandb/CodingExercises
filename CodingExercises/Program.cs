namespace CodingExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0";
            Console.WriteLine(Sequence(str));
        }

        public static int Sequence(string x) 
        {
            string[] sales = x.Split(',');
            int sum = 0;
            int max = 0;
            foreach (string s in sales) 
            {
                if (s == "0")
                {
                    sum++;
                }
                else
                {
                    sum = 0;
                }
                if(sum>max) { max = sum; }
            }
            return max;
        }
    }
}
