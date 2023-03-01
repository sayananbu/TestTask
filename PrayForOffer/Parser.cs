using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrayForOffer
{
    public static class Parser
    {
        public static string[][] ParseStringArray(string[] arr)
        {
            if (arr == null || arr.Length < 1) return new string[][] { };

            List<string[]> resultList = new List<string[]>();
            List<string> buffer = new List<string>();
            List<string> arrCopy = arr.ToList();

            for (int i = 0; i < arrCopy.Count; i++)
            {
                for (int j = i; j < arrCopy.Count; j++)
                {
                    for (int k = 0; k < arrCopy[j].Length; k++)
                    {
                        if (arrCopy[i].Length== arrCopy[j].Length && 
                            arrCopy[i].Contains(arrCopy[j][k], StringComparison.OrdinalIgnoreCase))
                        {
                            if (k + 1 == arrCopy[j].Length)
                                buffer.Add(arrCopy[j]);
                        }
                        else break;
                    }
                }
                resultList.Add(buffer.ToArray());
                arrCopy = arrCopy.Except(buffer).ToList();
                buffer.Clear();
                i--;
            }
            return resultList.ToArray();
        }
    }
}
