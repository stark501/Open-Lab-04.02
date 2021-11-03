using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string doubled = "";
            foreach (char ch in original)
            {
                doubled += ch.ToString() + ch.ToString();
            }
            return doubled; ;
        }
    }
}
