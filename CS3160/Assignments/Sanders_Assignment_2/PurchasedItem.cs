//*********************************************************************
// Assignment 2 -	 Fast-food restaurant
//			
// Programmer:	Sidney Sanders
// Class:		CS 3160-1001 Spring 2021
//
// File:    PurchasedItem.cs
//
//*********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchased
{
    class PurchasedItem
    {

        private static decimal[,] itemCost; // 2-d array of item costs
        private static string format;

        private int itemType;
        private int itemSize;
        private int totalItems;

        static PurchasedItem()
        {
            format = "{0, 2} {1, 1} {2, -15} {3, 10:C}";
            itemCost = new decimal[4, 3]
            {
                 {2.50M, 3.00M, 3.50M},
                 {0.99M, 1.29M, 1.49M},
                 {1.29M, 1.40M, 1.60M},
                 {0.00M, 0.00M, 0.00M}
            };
        }

        public PurchasedItem(int formItem, int formSize, int index)
        {
            itemType = formItem;
            itemSize = formSize;
            totalItems = index;

        }
        public decimal Cost()
        {
            return totalItems * itemCost[itemType, itemSize];
        }

        public override string ToString()
        {
            string food;
            char s;

            //item
            if (itemType == 0)
                food = "Sandwhich";
            else if (itemType == 1)
                food = "Fries";
            else if (itemType == 2)
                food = "Soft Drink";
            else
                food = "Water";

            //size

            if (itemSize == 0)
                s = 'S';
            else if (itemSize == 1)
                s = 'M';
            else
                s = 'L';

            return string.Format(format, totalItems, s, food, Cost());
        }

    }
}
