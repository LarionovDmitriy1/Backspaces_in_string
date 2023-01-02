using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backspaces_in_string;

public class BackSpacesInString
{
    public static string CleanString(string s)
    {
        string result = "";
        List<char> charList = s.ToList();
        for (int i = 0; i < charList.Count - 1;)
        {
            if (charList[i + 1] == '#')
            {
                if (charList[i] == '#') { i++; continue; }
                charList.RemoveAt(i);
                charList.RemoveAt(i);
                i = 0;
                continue;
            }
            i++;
        }
        for (int i = 0; i < charList.Count;)
        {
            if (charList[i] == '#')
            {
                charList.Remove(charList[i]);
            }
            else
            {
                i++;
                continue;
            }
        }
        foreach (char c in charList)
        {
            result += c;
        }
        return result;
    }
}
