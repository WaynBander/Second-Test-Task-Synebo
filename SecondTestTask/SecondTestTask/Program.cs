using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            Console.WriteLine("Enter the temperature through a space:");
            line = Console.ReadLine();
            string[] info = line.Split(new Char[] { ' ', ',', '.', ':', '\t', '\n' });
            int[] data = new int[info.Length];
            for (int i = 0; i < info.Length; i++)
                data[i] = Convert.ToInt32(info[i]);

            data = TemperatureResult(data);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Shortest winter:  " + data[i]);
            }
            Console.ReadLine();
        }
        public static int[] TemperatureResult(int[] Data)
        {
            int k1 = 0;
            List<int> result = new List<int>();
            List<int> fresult = new List<int>();
            result.Add(Data[0]);
            for (int i = 1; i < Data.Length; i++)
            {
                if (Data[i] < 0)
                {
                    result.Add(Data[i]);
                }
                else
                {
                    k1 = i;
                    break;
                }
            }
            for (int i = k1; i < Data.Length; i++)
            {
                if (Data[i] < 0)
                {
                    fresult.Add(Data[i]);
                }
                else
                {
                    if (fresult.Count < result.Count && fresult.Count != 0)
                    {
                        result.Clear();
                        result = fresult;
                        fresult.Clear();
                    }
                }
            }
            int[] data = new int[result.Count];
            for (int i = 0; i < result.Count; i++)
                data[i] = result[i];
            return data;
        }
    }
}
