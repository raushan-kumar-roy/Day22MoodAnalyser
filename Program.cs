using System.Runtime.CompilerServices;

namespace ArthmaticProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            //try
            //{
            //    Mood mood = new Mood();
            //    mood.Happy();
            //}
            //catch (MoodIsNullException m)
            //{
            //    Console.WriteLine(m.Message);
            //}

            try
            {
                Mood mood = new Mood();
                mood.Emtpy();
            }
            catch (MoodIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}