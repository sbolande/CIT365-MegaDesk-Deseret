using System;
using System.Collections.Generic;
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
            switch (Desk.ProductionDays)
            {
                case 3:
                    if (size < 1000) return 60;
                    else if (size >= 1000 && size <= 2000) return 70;
                    else if (size > 2000) return 80;
                    else return 0;
                case 5:
                    if (size < 1000) return 40;
                    else if (size >= 1000 && size <= 2000) return 50;
                    else if (size > 2000) return 60;
                    else return 0;
                case 7:
                    if (size < 1000) return 30;
                    else if (size >= 1000 && size <= 2000) return 35;
                    else if (size > 2000) return 40;
                    else return 0;
                default:
                    return 0;
            }
        }
    }
}
