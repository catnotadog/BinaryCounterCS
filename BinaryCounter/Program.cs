using System;
using System.Linq;
using System.Threading;

namespace BinaryCounter
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("cnad binary counter\npress any key to start");
            Console.ReadKey();
            var bitarray = new short[32];
            ref var bits = ref bitarray;
            ref var bit0 = ref bits[0];
            var decimalnum = 0;
            ref var dnum = ref decimalnum;
            while (dnum < int.MaxValue)
            {
                bit0++;
                for (var i = 0; i < bits.Count(); i++)
                {
                    if (bits[i] <= 1) continue;
                    bits[i] = 0;
                    bits[i + 1]++;
                }
                dnum++;
                foreach (var bit in bits.Reverse())
                {
                    Console.Write(bit);
                }

                Console.Write($"  ({dnum})\n");
                if (args.Contains("--slowdown"))
                {
                    Thread.Sleep(100);
                }
            }

        }

        /*public static void Mainint16(string[] args)
        {
            Console.WriteLine("cnad binary counter\npress any key to start");
            Console.ReadKey();
            var bits = new short[32];

            bits[0] = 0;
            var decimalnum = 0;
            while (decimalnum < int.MaxValue)
            {
                bits[0]++;
                for (var i = 0; i < bits.Count(); i++)
                {
                    if (bits[i] <= 1) continue;
                    bits[i] = 0;
                    bits[i + 1]++;
                }

                decimalnum++;

                foreach (var bit in bits.Reverse())
                {
                    Console.Write(bit);
                }

                Console.Write($"  ({decimalnum})\n");
                if (args.Contains("--slowdown"))
                {
                    Thread.Sleep(100);
                }
            }

        }
        public static void Mainint32(string[] args)
                      {
                          Console.WriteLine("cnad binary counter\npress any key to start");
                          Console.ReadKey();
                          var bits = new int[32];
                          bits[0] = 0;
                          var decimalnum = 0;
                          while (bits.Sum() != 32)
                          {
                              bits[0]++;
                              for (var i = 0; i < bits.Count(); i++)
                              {
                                  if (bits[i] <= 1) continue;
                                  bits[i] = 0;
                                  bits[i + 1]++;
                              }
              
                              decimalnum++;
              
                              foreach (var bit in bits.Reverse())
                              {
                                  Console.Write(bit);
                              }
              
                              Console.Write($"  ({decimalnum})\n");
                              if (args.Contains("--slowdown"))
                              {
                                  Thread.Sleep(100);
                              }
                          }
                      }*/
    }
}