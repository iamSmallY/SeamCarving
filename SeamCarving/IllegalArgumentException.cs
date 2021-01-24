using System;

namespace SeamCarving
{
    class IllegalArgumentException : Exception
    {
        public IllegalArgumentException(string message) : base(message) { }
    }
}
