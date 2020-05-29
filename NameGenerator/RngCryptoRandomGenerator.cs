using System;
using System.Security.Cryptography;

namespace NameGenerator
{
    public class RngCryptoRandomGenerator : IRandomGenerator
    {
        private readonly RandomNumberGenerator _rng;
        private readonly byte[] _rngBuffer;

        public RngCryptoRandomGenerator()
        {
            _rng = new RNGCryptoServiceProvider();
            _rngBuffer = new byte[4];
        }

        public byte NextRandomByte()
        {
            _rng.GetBytes(_rngBuffer, 0, 1);
            return (byte)(int) _rngBuffer[0];
        }

        public int NextRandomInt()
        {
            _rng.GetBytes(_rngBuffer);
            _rngBuffer[3] &= 0x7f;
            return BitConverter.ToInt32(_rngBuffer, 0);
        }

    }
}