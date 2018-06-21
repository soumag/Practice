using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class Solution756
    {
        public bool PyramidTransition(string bottom, IList<string> allowed)
        {
            // Create a map
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string str in allowed)
            {
                string key = str.Substring(0, 2);
                string value = str.Substring(2);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string> { value });
                }
                else
                {
                    dict[key].Add(value);
                }
            }

            return PyramidHelper(bottom, dict);
        }

        private bool PyramidHelper(string bottom, Dictionary<string, List<string>> dict)
        {
            if (bottom.Length == 1)
            {
                return true;
            }

            for (int i=0; i<bottom.Length-1; i++)
            {
                if (!dict.ContainsKey(bottom.Substring(i, 2)))
                    return false;
            }
            List<string> newBottoms = new List<string>();
            GetList(bottom, 0, new StringBuilder(), newBottoms, dict);
            foreach (var newBottom in newBottoms)
            {
                if (PyramidHelper(newBottom, dict))
                    return true;
            }

            return false;
        }

        private void GetList(string bottom, int index, StringBuilder sb, List<string> resList, Dictionary<string, List<string>> dict)
        {
            if (index == bottom.Length-1)
            {
                resList.Add(sb.ToString());
                return;
            }

            foreach (var value in dict[bottom.Substring(index, 2)])
            {
                sb.Append(value);
                GetList(bottom, index + 1, sb, resList, dict);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
