using System;

namespace Crypto_Profit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            double CPcrypto = 0;
            double HMmoney = 0;
            double HMfee = 0;
            double HMCrypto = 0;
            string BuyOrSell = string.Empty;
            string Process = string.Empty;

            while (BuyOrSell == string.Empty)
            {
                Console.WriteLine("What would you like to do?" + Environment.NewLine + "'B' for Buy and 'S' for sell");
                BuyOrSell = Console.ReadLine();

                if (BuyOrSell.ToLower() == "b") { Process = "Buying"; }
                else if (BuyOrSell.ToLower() == "s") { Process = "Selling"; }
                else { BuyOrSell = string.Empty; }
                Console.Clear();
            }

            while (CPcrypto == 0)
            {
                Console.WriteLine("What's the current price of your Crypto? ");
                CPcrypto = double.Parse(Console.ReadLine());
                Console.Clear();
            }

            if (Process.ToLower() == "selling")
            {
                while (HMCrypto == 0)
                {
                    Console.WriteLine("How much cryto are you playing with? ");
                    HMCrypto = double.Parse(Console.ReadLine());
                }

                HMfee = (HMCrypto * 0.005) * CPcrypto;
                Console.Clear();
            }
            else
            {
                while (HMmoney == 0)
                {
                    Console.WriteLine("How much money are you playing with? ");
                    HMmoney = double.Parse(Console.ReadLine());
                }

                HMfee = HMmoney * 0.005;
                Console.Clear();
            }

            double TempHolder = HMmoney + HMCrypto;

            Console.WriteLine("Current price of your crypto: " + CPcrypto);
            Console.WriteLine("Amount you're " + Process + ": " + TempHolder);
            Console.WriteLine(Process + " fee: " + HMfee);

            if (Process.ToLower() == "buying")
            {
                Console.WriteLine("You get " + (HMmoney - HMfee) / CPcrypto + " in Crypto");
            }
            else if (Process.ToLower() == "selling")
            {
                Console.WriteLine("Gross profit: " + HMCrypto * CPcrypto);
                Console.WriteLine("Profit: " + HMCrypto * CPcrypto * 0.995);
            }

            string AnyKey = string.Empty;
            while (AnyKey == string.Empty)
            {
                Console.WriteLine("Press any key to exit");
                AnyKey = Console.ReadKey().ToString();
            }





        }
    }
}
