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

            Random r = new Random();
            int genRand= r.Next(1,20);
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
            Console.Write($"{question}: ");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine(answer);
        }
    }
}
