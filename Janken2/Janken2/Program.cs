using System;

namespace Janken2
{
    class Program
    {
        static string[] Handsn = { "グー", "チョキ", "パー" };
        static void Main()
        {
            Console.WriteLine("プレイヤー人数を入力(1～5人)");
            string Nplayers_str = Console.ReadLine();
            Nplayers_str = Check_Nplayers(Nplayers_str);
            int Nplayers = int.Parse(Nplayers_str);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("CPU人数を入力(1～5人)");
            string Ncomputers_str = Console.ReadLine();
            Ncomputers_str = Check_Ncomputers(Ncomputers_str);
            int Ncomputers = int.Parse(Ncomputers_str);
            Console.WriteLine(Environment.NewLine);

            int[] Players = new int[Nplayers];
            int[] Computers = new int[Ncomputers];

            for(int i = 0;i < Nplayers; i++)
            {
                Console.WriteLine("プレイヤー" + i);
                Console.WriteLine("0～2のいづれかを入力");
                Console.WriteLine("0:グー");
                Console.WriteLine("1:チョキ");
                Console.WriteLine("2:パー");
                string Hand_str = Console.ReadLine();
                Hand_str = Check_Hand(Hand_str);
                int Hand = int.Parse(Hand_str);
                Players[i] = Hand;
                Console.WriteLine("プレイヤー" + i + "は" + Handsn[Hand]);
                Console.WriteLine(Environment.NewLine);
            }

            for(int n = 0;n < Ncomputers; n++)
            {
                Console.WriteLine("CPU" + n);
                Random ran = new Random();
                int Hand = ran.Next(3);
                Computers[n] = Hand;
                Console.WriteLine("CPU" + n + "は" + Handsn[Hand]);
                Console.WriteLine(Environment.NewLine);
            }

            int[] HandAll = new int[Players.Length + Computers.Length];

            Players.CopyTo(HandAll, 0);
            Computers.CopyTo(HandAll, Players.Length);

            foreach (int a in HandAll)
            {
                Console.WriteLine(Handsn[a]);
            }
        }

        static string Check_Nplayers(string Nplayers_str)
        {
            // 1～5が入力されるまでループ
            while (true)
            {
                if (Nplayers_str == "1" || Nplayers_str == "2" || Nplayers_str == "3" || Nplayers_str == "4" || Nplayers_str == "5")
                {
                    return Nplayers_str;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("プレイヤー人数を入力(1～5人)");
                    Nplayers_str = Console.ReadLine();
                }
            }
        }
        static string Check_Ncomputers(string Ncomputers_str)
        {
            // 1～5が入力されるまでループ
            while (true)
            {
                if (Ncomputers_str == "1" || Ncomputers_str == "2" || Ncomputers_str == "3" || Ncomputers_str == "4" || Ncomputers_str == "5")
                {
                    return Ncomputers_str;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("CPU人数を入力(1～5人)");
                    Ncomputers_str = Console.ReadLine();
                }
            }
        }
        static string Check_Hand(string Hand_str)
        {
            // 0～2が入力されるまでループ
            while (true)
            {
                if (Hand_str == "0" || Hand_str == "1" || Hand_str == "2")
                {
                    return Hand_str;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("0～2のいづれかを入力");
                    Console.WriteLine("0:グー");
                    Console.WriteLine("1:チョキ");
                    Console.WriteLine("2:パー");

                    Hand_str = Console.ReadLine();
                }
            }
        }

    }
}