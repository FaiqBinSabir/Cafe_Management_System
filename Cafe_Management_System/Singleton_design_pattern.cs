using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    internal class Singleton_design_pattern
    {
        private static Singleton_design_pattern instance;
        private Singleton_design_pattern()
        {
            
        }

        //  method to access the singleton instance
        public static Singleton_design_pattern Instance
        {
            get
            {
                // Create the singleton instance if it doesn't exist
                if (instance == null)
                {
                    instance = new Singleton_design_pattern();
                }
                return instance;
            }
        }
    }
}
