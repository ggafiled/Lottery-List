﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_List
{
    class Permutations
    {
        private String tmp = "";
        public void permute(String str,int l, int r)
        {
            if (l == r)
                tmp += str +",";
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    permute(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }
        }

        public String get()
        {
            return tmp;
        }

        public String Swap(String a,int i, int j)
    {
        char temp;
        char[] charArray = a.ToCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        string s = new string(charArray);
        return s;
    }
    }
}
