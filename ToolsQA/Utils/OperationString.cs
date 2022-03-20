using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA
{
    public static class OperationString
    {
        public static string RemovePartString(string text, string removeString)
        {
            int remStr = text.IndexOf(removeString);
            string newText = text.Remove(remStr, removeString.Length);
            return newText;
        }
    }
}
