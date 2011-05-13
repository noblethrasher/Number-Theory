using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prelude
{
    public struct ModularInt
    {
        readonly int n;
        readonly int value;

        public ModularInt(int n, int value) : this()
        {
            this.n = n;
            this.value = value % n;
        }

        public static ModularInt operator +(ModularInt x, int y)
        {
            return new ModularInt(x.n, (x.value + y) % x.n);
        }

        public static ModularInt operator +(ModularInt x, ModularInt y)
        {
            return new ModularInt (x.n, (x.value + y.value) % x.n);
        }

        public static ModularInt operator ++(ModularInt x)
        {
            return new ModularInt(x.n, (x.value + 1) % x.n);
        }

        public static ModularInt operator -(ModularInt x, int y)
        {
            return new ModularInt (x.n, (x.value - y) % x.n);
        }

        public static ModularInt operator -(ModularInt x, ModularInt y)
        {
            return new ModularInt (x.n, (x.value - y.value) % x.n);
        }

        public static ModularInt operator --(ModularInt x)
        {
            return new ModularInt(x.n, (x.value - 1) % x.n);
        }

        public static ModularInt operator *(ModularInt x, int y)
        {
            return new ModularInt (x.n, (x.value * y) % x.n);
        }

        public static ModularInt operator *(ModularInt x, ModularInt y)
        {
            return new ModularInt (x.n, (x.value * y.value) % x.n);
        }

        public static implicit operator int(ModularInt x)
        {
            return x.value;
        }

    }
}
