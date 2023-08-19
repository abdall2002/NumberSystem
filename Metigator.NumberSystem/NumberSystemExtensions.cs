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
                    throw new InvalidOperationException($"'{source}' is invalid {numberBase}");
            }
        }
    }
}
