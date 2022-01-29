using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Deseret
{
    public class DeskQuote
    {
        // public int Id { get; set; } // could be used for search and display if we want
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Desk Desk { get; set; }
        public decimal Value { get; private set; } // private set, use CalculateQuote() to set this.Value

        public DeskQuote(string firstName, string lastName, Desk desk)
        {
            FirstName = firstName;
            LastName = lastName;
            QuoteDate = DateTime.Now;
            Desk = desk;
            CalculateQuote(); // initialize this.Value
        }

        public decimal CalculateQuote()
        {
            decimal size = (Desk.Width * Desk.Depth);
            decimal basePrice = 200 + size + (50 * Desk.DrawerCount) + GetDesktopMaterialPrice();
            decimal rushPrice = GetRushPrice(size);
            Value = basePrice + rushPrice;
            return Value;
        }

        private decimal GetDesktopMaterialPrice()
        {
            switch (Desk.DesktopMaterial)
            {
                case DesktopMaterial.Laminate: return 100;
                case DesktopMaterial.Oak: return 200;
                case DesktopMaterial.Rosewood: return 300;
                case DesktopMaterial.Veneer: return 125;
                case DesktopMaterial.Pine: return 50;
                default: return 0;
            }
        }

        private decimal GetRushPrice(decimal size)
        {
            int DayPosition;
            int SizePosition;

            if (Desk.ProductionDays < 14) DayPosition = DefineRushDayPosition(Desk.ProductionDays);
            else { return 0; }

            SizePosition = DefineRushSizePosition(size);

            return GetRushOrder(DayPosition, SizePosition);
        }

        private int DefineRushDayPosition(int productionDays)
        {
            switch (productionDays)
            {
                case 3:
                    return 0;
                case 5:
                    return 1;
                case 7:
                    return 2;
                default:
                    return 0;
            }
        }

        private int DefineRushSizePosition(decimal productionSize)
        {
            if (productionSize < 1000) return 0;
            else if (productionSize > 1000 && productionSize < 2000) return 1;
            else return 2;
        }

        private int GetRushOrder(int Day, int Size)
        {
            string textFile = AppDomain.CurrentDomain.BaseDirectory + @"/files/rushOrderPrices.txt";

            string[] lines = File.ReadAllLines(textFile);
            int[] rushPrices = lines.Select(int.Parse).ToArray();

            int ROWS = 3;
            int COLUMNS = 3;
            int[,] PriceByDays = new int[3,3];


            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    PriceByDays[i,j] = rushPrices[(i * COLUMNS) + j];
                }
                    
            }

            return PriceByDays[Day,Size];
        }
    }
}
