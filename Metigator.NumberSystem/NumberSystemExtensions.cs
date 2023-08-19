using Metigator.NumberSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metigator.NumberSystem
{
    public static class NumberSystemExtensions
    {
        public static void Guard(this string source, string allowedCharacter, NumberBase numberBase)
        {

            foreach (var ch in source)
            {
                if (!allowedCharacter.Contains(ch))
                    throw new InvalidOperationException($"'{source}' is invalid {numberBase} format");
            }

        }



        public static string To<T>(this T source, NumberBase toBase) where T : Base
        {

            Console.WriteLine("This will be shown in debug mode only");

            NumberBase fromBase;


            switch (source)
            {
                case BinarySystem: fromBase = NumberBase.BINARY; break;
                case OctalSystem: fromBase = NumberBase.OCTAL; break;
                case DecimalSystem: fromBase = NumberBase.DECIMAL; break;
                case HexadecimalSystem: fromBase = NumberBase.HEXADECIMAL; break;
                default: fromBase = NumberBase.DECIMAL; break;
            }

            return Convert.ToString(Convert.ToInt32(source.Value, (int)fromBase), (int)toBase);
        }
    }
}
