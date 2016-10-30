using System;
using System.Collections.Generic;

namespace Vending
{
    public class Screen
    {
        public List<AProduct> ListFromScreen { get; set; }

        public Screen()
        {
             
        }

        
        public int Show()
        {
            Console.WriteLine("Код:\tНаименование");
            Console.WriteLine();

            for (int i = 0; i < ListFromScreen.Count; i++)
            {
                if (ListFromScreen[i].Amount>0)
                Console.WriteLine(ListFromScreen[i].Id + ":\t" +ListFromScreen[i].Name);
            }
            int result = 0;
            while (true)
            {
                Console.Write("Наберите код продукта:  ");
                int tmp = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 0; i < ListFromScreen.Count; i++)
                {
                    if (ListFromScreen[i].Id == tmp)
                    {
                        result = i;
                        break;
                    }
                }
                if (result > 0) break;
            }

            return result;
        }

        public void ShowPrice(int position)
        {


            Console.WriteLine("Цена: " + ListFromScreen[position].Price + " руб.");
            Console.WriteLine("Внесите деньги");
           
        }


    }
}