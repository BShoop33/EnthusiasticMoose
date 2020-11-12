using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            //Ask a question
            MooseQuestion ();
            Console.ReadLine();

            Random r = new Random();
            int genRand= r.Next(1,20);
            if(genRand == 1)
            {
                Console.WriteLine("As I see it, yes.");
            }
            else if(genRand == 2)
            {
                Console.WriteLine("Ask again later.");
            }
            else if(genRand == 3)
            {
                Console.WriteLine("Better not tell you now.");
            }
            else if(genRand == 4)
            {
                Console.WriteLine("Cannot predict now.");
            }
            else if(genRand == 5)
            {
                Console.WriteLine("Concentrate and ask again.");
            }
            else if(genRand == 6)
            {
                Console.WriteLine("Don’t count on it.");
            }
            else if(genRand == 7)
            {
                Console.WriteLine("It is certain.");
            }
            else if(genRand == 8)
            {
                Console.WriteLine("It is decidedly so.");
            }
            else if(genRand == 9)
            {
                Console.WriteLine("Most likely.");
            }
            else if(genRand == 10)
            {
                Console.WriteLine("My reply is no.");
            }
            else if(genRand == 11)
            {
                Console.WriteLine("My sources say no.");
            }
            else if(genRand == 12)
            {
                Console.WriteLine("Outlook not so good.");
            }
            else if(genRand == 13)
            {
                Console.WriteLine("Outlook good.");
            }
            else if(genRand == 14)
            {
                Console.WriteLine("Reply hazy, try again.");
            }
            else if(genRand == 15)
            {
                Console.WriteLine("Signs point to yes.");
            }
            else if(genRand == 16)
            {
                Console.WriteLine("Very doubtful.");
            }
            else if(genRand == 17)
            {
                Console.WriteLine("Without a doubt.");
            }
            else if(genRand == 18)
            {
                Console.WriteLine("Yes.");
            }
            else if(genRand == 19)
            {
                Console.WriteLine("Yes – definitely.");
            }
            else if(genRand == 20)
            {
                Console.WriteLine("You may rely on it.");
            }
        }

        static void MooseQuestion ()
        {
        MooseAsks("What question may I answer for you today?");
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static void MooseAsks(string question)
        {
            Console.Write($"{question} ");
            // int answer = int.Parse(Console.ReadLine());
        }
    }
}
