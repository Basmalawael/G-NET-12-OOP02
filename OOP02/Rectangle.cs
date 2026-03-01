using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    #region Q2 : Example: Read-only property with a calculated value
    internal class Rectangle
    {
        public double width { get; set; }
        public double height { get; set; }

        /// Read-only property that returns a calculated value
        public double Area
        {
            get { return width * height; }
        }
    }
    #endregion
}
