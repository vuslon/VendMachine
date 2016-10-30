using System;
using System.Collections.Generic;

namespace Vending
{
    public class CashBox
    {
        public int cash;

        public CashBox()
        {
            cash = 100;
        }

        public int GetMoney()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void TakeResult(int money)
        {
            Console.WriteLine("Выдана сдача: "+ money);
        }

        public int Buy(int money, int price)
        {
            int a = money - price;
            cash += price;
            return a;
        }
    }
}