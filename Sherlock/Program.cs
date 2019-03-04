using System;

namespace Sherlock
{
    public static class Program
    {
        public static void Main()
        {
           // string press = { "a reporter from the Times", "a reporter from the Observer" };
           // fixing error in above given code by putting values in press[] array
           string[] press = new string[] { "a reporter from the Times", "a reporter from the Observer" };

            // string family = {"Mycroft Holmes", "Mrs. Hudson" };
            // fixing error in above given code by putting values in family[] array
            string[] family = new string[] { "Mycroft Holmes", "Mrs. Hudson" };
            // string enemies = {"Professor Moriarty", "Charles "Augustus" Milverton", "John Woodley" };
            string[] enemies = new string[] { "Professor Moriarty", "Charles Augustus Milverton", "John Woodley" };
            //string loveInterests = {"Irene Adler" };
            string[] loveInterests = new string[] { "Irene Adler" };

            //string friends = {"Inspector Lestrade", "Dr. Watson" };.
            string[] friends = new string[] { "Inspector Lestrade", "Dr. Watson" };

            Console.WriteLine(KnockKnock(press));
            Console.WriteLine(KnockKnock(family));
            Console.WriteLine(KnockKnock(enemies));
            Console.WriteLine(KnockKnock(loveInterests));
            Console.WriteLine(KnockKnock(friends));

            Console.ReadLine();
        }

        private static string KnockKnock(string[] guests)
        {         
            string result = "mymessage";
            foreach (string guest in guests)
            {
               // Console.WriteLine(guest);
                //Console.ReadLine();
          
                for (int i = 0; i < guests.Length; i++)
                    if (guest == "Dr. Watson" || guest == "Mrs. Hudson") // Inspector Lestrade was original value in code
                    {
                        result = "Enter";
                        break;
                    }
                    else
                    {
                        result = "Go Away! (sound of violin music...)";
                    }     
            }
            return result;
        }
    }
}
