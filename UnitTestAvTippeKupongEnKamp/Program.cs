using System;

namespace UnitTestAvTippeKupongEnKamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine().ToUpper();
            var match = new Match(bet);

            while (match.matchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine().ToUpper();

                if (command == "X") match.matchIsStoped();

                else if (command == "H" || command == "B") match.Goals(command == "H");
                Console.WriteLine(match.ScoreText());
            }
            Console.WriteLine(match.AreBetCorrectText());


        }
    }
}
