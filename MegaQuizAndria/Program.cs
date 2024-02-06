using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] quiz = new string[]
        {
            "Capital of France?:Paris",
            "Capital of Georgia?:Tbilisi",
            "Where is Berlin located?:Germany",
            "Where is China located?:Asia",
            "Capital of Italy?:Rome",

            "Capital of saudi arabia?:Riyadh",
            "Capital of UAE:Abhu dhabi",
            "Capital of Malaysia?:Kuala Lumpur",
            "Where is Egypt located?:Africa",
            "Capital of Mexico?:Mexico city",

            "Where is Canada located?:North America",
            "Capital of United states?:Washington DC",
            "Capital of UK?:London",
            "Where is Poland located?:Europe",
            "Capital of Russia?:Moscow",

            "Capital of Japan?:Tokyo",
            "Capital of China?:Beijing",
            "Where is Vienna located?:Austria",
            "Where is Canberra located?:Australia",
            "Capital of Portugal?:Lisbon"
        };

        using (StreamWriter qwrite = new StreamWriter("test.txt"))
        {
            foreach (string question in quiz)
            {
                qwrite.WriteLine(question);
            }
        }

        string[] thinredline = File.ReadAllLines("test.txt");

        int points = 0;

        foreach (string line in thinredline)
        {
            var ss = line.Split(":");
            Console.WriteLine(ss[0]);
            var answer = Console.ReadLine();
            if (answer == ss[1])
            {
                Console.WriteLine("Correct");
                ++points;
            }
            else
            {
                Console.WriteLine("Incorrect" + " " + "The answer was:" + " " + ss[1]);
            }
        }
        Console.WriteLine("You scored" + " " + points + " " + "out of 5 points");
    }
}