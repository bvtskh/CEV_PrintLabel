using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.Graph
{
    public static class DefineColor
    {
        public static Color GetColor(int color)
        {
            switch(color)
            {
                case 0: return Color.Red; 
                case 1: return Color.Green; 
                case 2: return Color.Blue; 
                case 3: return Color.Magenta; 
                case 4: return Color.Yellow; 
                case 5: return Color.Orange; 
                case 6: return Color.Orchid;
                case 7: return Color.HotPink;
                case 8: return Color.Indigo;
                case 9: return Color.LightSkyBlue;
                case 10: return Color.Lime;
                case 11: return Color.Maroon;
                case 12: return Color.MediumPurple;
                case 13: return Color.MintCream;
                case 14: return Color.Tan;
                case 15: return Color.IndianRed;
                case 16: return Color.Brown;
                case 17: return Color.Crimson;
                case 18: return Color.Fuchsia;
                default: return Color.Gray;
            }
        }
    }
}
