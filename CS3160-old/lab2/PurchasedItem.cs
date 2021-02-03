using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class PurchasedItem
    {
        private int item;
        private int size;
        private int quantity;
        private static string format;
        private static decimal[,] itemCost;


        static PurchasedItem() 
        { 
            format = "{0, 2}  {1, 1} {2, -15} {3, 10:C}"; 
            itemCost = new decimal[4, 3] 
            { 
                { 2.50M, 3.00M, 3.50M }, 
                { 0.99M, 1.29M, 1.49M }, 
                { 1.29M, 1.40M, 1.60M }, 
                { 0.00M, 0.00M, 0.00M } 
            }; 
        }
        public PurchasedItem(int i, int s, int q)
        {
            item = i;
            size = s;
            quantity = q;
        }

        public decimal Cost()
        {
            return quantity * itemCost[item, size];
        }

        public override string ToString()
        {
            string food;
            char s;

            if(item == 0)
            {
                food = "Sandwhich";
            }
            else if(item == 1)
            {
                food = "Fries";
            }
            else if(item == 2)
            {
                food = "Soft Drink";
            }
            else
            {
                food = "Water";
            }

            if(size == 0)
            {
                s = 'S';
            }
            else if(size == 1)
            {
                s = 'M';
            }
            else
            {
                s = 'L';
            }
       
            return string.Format(format, quantity, s, food, Cost());
        }

    }
}
