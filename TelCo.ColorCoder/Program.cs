using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
       internal static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        internal static Color[] colorMapMinor;
        
    /// <summary>
     ///  Given the inbuilt colors and pair number the function return the mapping
    /// </summary> 

        public override string  ToString ()
    {
        string colorPairMapping= " ";
        for (int pairNumber=1;pairNumber<=25; pairNumber++)
        {
            ColorPair colorPair= GetColorPair.GetColorFromPairNumber(pairNumber);
            colorPairMapping += pairNumber + "\t" + colorPair + "\n"; 
        }
        return colorPairMapping;
    }
        /// <summary>
         /// Static constructor required to initialize static variable
        /// </summary>
        static Program()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

       
    }
}
