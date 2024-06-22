using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class Choice
    {
        public static Choice Rock { get; internal set; }
        public static Choice Scissors { get; internal set; }
        public static Choice Paper { get; internal set; }

        public static explicit operator Choice(int v)
        {
            throw new NotImplementedException();
        }
    }
}
