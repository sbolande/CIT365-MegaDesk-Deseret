using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        // CONSTANTS
        private const int _widthMin = 24;
        private const int _widthMax = 96;
        private const int _depthMin = 12;
        private const int _depthMax = 48;
        private const int _drawerCountMax = 7;

        private decimal _width;
        public decimal Width
        {
            get { return _width; }
            set
            {
                if (value < _widthMin)
                {
                    Console.WriteLine($"An unexpected error occured: Width must be greater than {_widthMin}.");
                    // default to minimum width
                    _width = _widthMin;
                }
                else if (value > _widthMax)
                {
                    Console.WriteLine($"An unexpected error occured: Width must be less than {_widthMax}.");
                    // default to maximum width
                    _width = _widthMax;
                }
                else
                {
                    _width = value;
                }
            }
        }
        private decimal _depth;
        public decimal Depth
        {
            get { return _depth; }
            set
            {
                if (value < _depthMin)
                {
                    Console.WriteLine($"An unexpected error occured: Depth must be greater than {_depthMin}.");
                    // default to minimum depth
                    _depth = _depthMin;
                }
                else if (value > _depthMax)
                {
                    Console.WriteLine($"An unexpected error occured: Depth must be less than {_depthMax}.");
                    // default to maximum depth
                    _depth = _depthMax;
                }
                else
                {
                    _depth = value;
                }
            }
        }
        private int _drawerCount;
        public int DrawerCount
        {
            get { return _drawerCount; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"An unexpected error occured: # of drawers must be between {0} and {_drawerCountMax}.");
                    // default to minimum depth
                    _drawerCount = 0;
                }
                else if (value > _drawerCountMax)
                {
                    Console.WriteLine($"An unexpected error occured: # of drawers must be less than {_drawerCountMax}.");
                    // default to maximum depth
                    _drawerCount = _drawerCountMax;
                }
                else
                {
                    _drawerCount = value;
                }
            }
        }
        public DesktopMaterial DesktopMaterial { get; set; }
        private int _productionDays = 14;
        public int ProductionDays
        {
            get { return _productionDays; }
            set
            {
                if (value == 14 || value == 7 || value == 5 || value == 3)
                {
                    _productionDays = value;
                }
                else
                {
                    Console.WriteLine("An unexpected error occured: ProductionDays must be one of '14', '7', '5', or '3'.");
                    // default to 14 days
                    _productionDays = 14;
                }
            }
        }

        public Desk(decimal width, decimal depth, int drawerCount, DesktopMaterial desktopMaterial, int productionDays)
        {
            Width = width;
            Depth = depth;
            DrawerCount = drawerCount;
            DesktopMaterial = desktopMaterial;
            ProductionDays = productionDays;
        }
    }

    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
}
