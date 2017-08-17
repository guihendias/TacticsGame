using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{
    public static class Utils
    {
        private static Random random = null;

        public static int EnumCount<T>() where T : IConvertible
        {
            return Enum.GetNames(typeof(T)).Length;
        }

        public static int Random(int max)
        {
            if (random == null)
            {
                random = new Random((int)DateTime.Now.Ticks);
            }

            return random.Next(max);
        }
    }
}
