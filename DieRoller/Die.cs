using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    public class Die
    {
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }
        public Die()
        {
            Roll();
        }
        public byte FaceValue { get; private set; }
        public bool IsHeld { get; set; }
        public byte Roll()
        {
            if (!IsHeld)
            {
                Random random = new();
                byte newValue = (byte)random.Next(1, 7);
                FaceValue = newValue;
            }
            return FaceValue;
        }

    }
}
