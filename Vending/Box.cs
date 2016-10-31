using System;
using System.Collections.Generic;

namespace Vending
{
    public class Box
    {
        //Конструктор
        public Box ()
        {
            AddProduct();
            Sort();
        }

        public List<AProduct> Products { get; set; } = new List<AProduct>();

        private void AddProduct() //Добавление товара
        {
            Products.Add(new Drinkable(101, "Coca-Cola", 55, 5));
            Products.Add(new Drinkable(123, "Sprite   ", 50, 1));
            Products.Add(new Drinkable(467, "Fanta    ", 45, 0));
            Products.Add(new Drinkable(111, "Merinda  ", 60, 13));
            Products.Add(new Drinkable(345, "Pepsi    ", 65, 7));
            
         }

        private void Sort() //сортировка по ID товара))
        {
            for (int i = 0; i < Products.Count-1; i++)
            {
                if (Products[i].Id > Products[i+1].Id)
                {
                    List<AProduct> tmp = new List<AProduct>();
                    tmp.Add(Products[i]);
                    Products[i] = Products[i + 1];
                    Products[i + 1] = tmp[0];
                    i = 0;
                }
            }
        }

        public void TakeResult(int product) // имитация процесса выдачи товара из витрины
        {
            Console.WriteLine("Выдан продукт: " + Products[product].Name);
        }
    }
}