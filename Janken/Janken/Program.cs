using System;

namespace Janken
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1～3のいづれかを入力");
            Console.WriteLine("1:グー");
            Console.WriteLine("2:チョキ");
            Console.WriteLine("3:パー");

            string Player = Console.ReadLine();

            check(Player);

            janken(Player);
        }

        static string check(string Player)
        {
            // 1 2 3が入力されるまでループ
            while (true)
            {
                if (Player == "1" || Player == "2" || Player == "3")
                {
                    return Player;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("1～3のいづれかを入力");
                    Console.WriteLine("1:グー");
                    Console.WriteLine("2:チョキ");
                    Console.WriteLine("3:パー");

                    Player = Console.ReadLine();
                }
            }
        }

        static void janken(string Player)
        {
            Random ran = new Random();
            string Computer = ran.Next(1, 4).ToString();

            //負けた場合
            if (((Player == "1") && (Computer == "3")) ||
                ((Player == "2") && (Computer == "1")) ||
                ((Player == "3") && (Computer == "2")))
            {
                if (Player == "1")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: グー");
                    Console.WriteLine("Computer: パー");
                    Console.WriteLine("まけ");
                }
                else if (Player == "2")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: チョキ");
                    Console.WriteLine("Computer: グー");
                    Console.WriteLine("まけ");
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: パー");
                    Console.WriteLine("Computer: チョキ");
                    Console.WriteLine("まけ");
                }
            }
            //勝った場合
            else if (((Player == "1") && (Computer == "2")) ||
                     ((Player == "2") && (Computer == "3")) ||
                     ((Player == "3") && (Computer == "1")))
            {
                if (Player == "1")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: グー");
                    Console.WriteLine("Computer: チョキ");
                    Console.WriteLine("かち");
                }
                else if (Player == "2")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: チョキ");
                    Console.WriteLine("Computer: パー");
                    Console.WriteLine("かち");
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: パー");
                    Console.WriteLine("Computer: グー");
                    Console.WriteLine("かち");
                }
            }
            //あいこだった場合
            else
            {
                if (Player == "1")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: グー");
                    Console.WriteLine("Computer: グー");
                    Console.WriteLine("あいこ");
                    Console.WriteLine(Environment.NewLine);
                }
                else if (Player == "2")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: チョキ");
                    Console.WriteLine("Computer: チョキ");
                    Console.WriteLine("あいこ");
                    Console.WriteLine(Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Player: パー");
                    Console.WriteLine("Computer: パー");
                    Console.WriteLine("あいこ");
                    Console.WriteLine(Environment.NewLine);
                }

                Main();
            }
        }
    }
}