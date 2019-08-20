using System;

namespace Janken2
{
    class Program
    {
        static string[] Handsn = { "グー", "チョキ", "パー" };
        static void Main()
        {
            Console.WriteLine("プレイヤー人数を入力(1～5人)");
            int Nplayers = int.Parse(Console.ReadLine());
            Nplayers = Check_Nplayers(Nplayers);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("CPU人数を入力(1～5人)");
            int Ncomputers = int.Parse(Console.ReadLine());
            Ncomputers = Check_Ncomputers(Ncomputers);
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
                int Hand = int.Parse(Console.ReadLine());
                Players[i] = Hand;
                Hand = Check_Hand(Hand);
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
                Console.WriteLine(a);
            }
        }

        static int Check_Nplayers(int Nplayers)
        {
            // 1～5が入力されるまでループ
            while (true)
            {
                if (1<= Nplayers && Nplayers <= 5)
                {
                    return Nplayers;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("プレイヤー人数を入力(1～5人)");
                    Nplayers = int.Parse(Console.ReadLine());
                }
            }
        }
        static int Check_Ncomputers(int Ncomputers)
        {
            // 1～5が入力されるまでループ
            while (true)
            {
                if (1 <= Ncomputers && Ncomputers <= 5)
                {
                    return Ncomputers;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("CPU人数を入力(1～5人)");
                    Ncomputers = int.Parse(Console.ReadLine());
                }
            }
        }
        static int Check_Hand(int Hand)
        {
            // 0～2が入力されるまでループ
            while (true)
            {
                if (0 <= Hand && Hand <= 2)
                {
                    return Hand;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("0～2のいづれかを入力");
                    Console.WriteLine("0:グー");
                    Console.WriteLine("1:チョキ");
                    Console.WriteLine("2:パー");

                    Hand = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}