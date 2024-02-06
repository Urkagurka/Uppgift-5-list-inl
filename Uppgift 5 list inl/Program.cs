using System;

namespace Uppgift_5_list_inl
{
    class program
    {
        static void Main(string[] args)
        {
            List<int> löner = new List<int>();
            int lönmedelvärde = 0;

            while (true)
            {
                Console.WriteLine("Hur mycket har du tjänat i lön");
                int lön = int.Parse(Console.ReadLine());
                if (lön == 0)
                {
                    break;
                }
                löner.Add(lön);
            }

            if (löner.Count == 0) 
            {
                Console.WriteLine("inga värden");
                return;
            }

            for (int i = 0; i < löner.Count; i++)
            {
                lönmedelvärde = (lönmedelvärde + löner[i]);
            }
            lönmedelvärde = lönmedelvärde / löner.Count;
            Console.WriteLine("lönernas medelvärde är " + lönmedelvärde);


            löner.Sort();
            int lönmedian = 0;

            if (löner.Count % 2  == 0)
            {

                lönmedian = (löner[löner.Count / 2] + löner[löner.Count / 2 - 1]) / 2;
            }
            else 
            {
                lönmedian = löner[(löner.Count - 1) / 2];
            }
            Console.WriteLine("lönernas medianvärde är " + lönmedian);

        }
    }
}