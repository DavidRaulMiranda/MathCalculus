﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculus
{
    static class RandomLib
    {
        public static int GeneraRandom(int min, int max, int seed)
        {
            int number;
            number = Math.Abs(seed) % ((max + 1) - min);
            return number + min;
        }
        public static int GeneraRandom(int min, int max)
        {
            int seed, number;
            seed = RandomSeed();
            number = Math.Abs(seed) % ((max + 1) - min);
            return number + min;
        }
        public static int RandomSeed()
        {
            using (RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider())
            {
                byte[] valor = new byte[4];
                rngCrypt.GetBytes(valor);
                return BitConverter.ToInt32(valor, 0);
            }
        }
    }
}
