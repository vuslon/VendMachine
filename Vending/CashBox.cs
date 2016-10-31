using System;
using System.Collections.Generic;

namespace Vending
{
    public class CashBox
    {
        public int cash;

        //Конструктор
        public CashBox()
        {
            cash = 100;
        }

        //Имитация приема денег через купюроприемник
        public int GetMoney()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        //Имитация выдачи сдачи
        public void TakeResult(int money)
        {
            Console.WriteLine("Выдана сдача: "+ money);
        }

        //Проведение оплаты, занесение выручки в кассу, расчет сдачи
        public int Buy(int money, int price)
        {
            int a = money - price;
            cash += price;
            return a;
        }
    }
}