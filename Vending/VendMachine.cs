using System;
using System.Threading;

namespace Vending
{
    public class VendMachine : IMachine
    {
        // обявление полей 
        Box _box;
        Screen _screen;
        CashBox _cashBox;

        // конструктор
        public VendMachine() 
        {
            _box = new Box();
            _screen = new Screen();
            _cashBox = new CashBox();
            Logic();
        }


        //Логика программы
        private void Logic()
        {
            while (true) 
            {
                
                int prodPos = ShowList();
                
                int money = ShowPrice(prodPos);
                
                if (money >= _box.Products[prodPos].Price) //если денег внесли достаточно для покупки товара
                {
                    int changeMoney = _cashBox.Buy(money, _box.Products[prodPos].Price);
                    TakeResult(prodPos, changeMoney);
                }
                else // если денег недостаточно для оплаты товара
                {
                    Console.WriteLine("Недостаточно денег");
                    TakeResult(-1, money); // так как в первом значении передаётся индекс Листа и оно может быть равно 0, 
                                           // то -1 передаётся чтоб не запускался механизм выдачи товара
                }
              
            }
        }


        
        //Начальный экран. Демонстрация наименований.
        public int ShowList()
        {
            Console.Clear();
            _screen.ListFromScreen = _box.Products; //Копирование списка товаров из бокса в память экрана
            Console.WriteLine("В кассе {0} руб.", _cashBox.cash);
            int a =_screen.Show();

            return a;
        }

        
        public int ShowPrice(int position)
        {
           _screen.ShowPrice(position);    //Демонстрация цены выбранного товара 
            int a =  _cashBox.GetMoney();  // и оплата
            
            return a;
        }

        //Выдача результата (товар, сдача)
        public void TakeResult(int product, int changeMoney)
        {
            Console.Clear();
            if (product >= 0) // выдача товара по индексу Листа
            {
                _box.TakeResult(product);
                _box.Products[product].Amount--; 
            }
            if (changeMoney > 0) //выдача сдачи
            {
                _cashBox.TakeResult(changeMoney);
            }
            Thread.Sleep(7000);
           
        }
    }
}