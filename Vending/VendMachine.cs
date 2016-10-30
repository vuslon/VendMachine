using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Vending
{
    public class VendMachine : IMachine
    {

        Box _box;
        Screen _screen;
        CashBox _cashBox;

        public VendMachine()
        {
            _box = new Box();
            _screen = new Screen();
            _cashBox = new CashBox();
            Logic();
        }

        private void Logic()
        {
            while (true)
            {
                int prodPos = ShowList();
                
                int money = ShowPrice(prodPos);
                
                if (money >= _box.Products[prodPos].Price)
                {
                    int changeMoney = _cashBox.Buy(money, _box.Products[prodPos].Price);
                    TakeResult(prodPos, changeMoney);
                }
                else
                {
                    Console.WriteLine("Недостаточно денег");
                    TakeResult(0, money);
                }
              
            }
        }

        private void InitFieldFromBox()
        {
             _screen.ListFromScreen = _box.Products;
        }
        

        public int ShowList()
        {
            InitFieldFromBox();
            Console.WriteLine("В кассе {0} руб.", _cashBox.cash);
            int a =_screen.Show();
            Console.Clear();
            return a;
        }

        public int ShowPrice(int position)
        {
           _screen.ShowPrice(position);
           int a =  _cashBox.GetMoney();
            Console.Clear();
            return a;
        }

        public void TakeResult(int product, int changeMoney)
        {
            if (product > 0)
            {
                _box.TakeResult(product);
                _box.Products[product].Amount--;
            }
            if (changeMoney > 0)
            {
                _cashBox.TakeResult(changeMoney);
            }
            Thread.Sleep(7000);
            Console.Clear();
        }
    }
}