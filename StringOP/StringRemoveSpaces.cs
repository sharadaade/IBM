using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.StringOP
{
    internal class StringRemoveSpaces
    {
        static void Main(string[] args)
        {
            string str = "I Love India";

            StringBuilder st = new StringBuilder();

            foreach(char c in str)
            {
                if(c != ' ')
                {
                    st.Append(c);
                }
            }
            Console.WriteLine(st);
        }
    }
}
