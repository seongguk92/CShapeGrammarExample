using System;
using System.Text;

namespace CShapeGrammarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String

            //ProcessString();

            //ProcessStringBuilder();
            #endregion
        }
        #region String
        private static void ProcessStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A");
            sb.Append("B");
            sb.Append("C");
            sb.Append("D");
            sb.Append("E");
            sb.Append("F");
            Console.WriteLine(sb);
            //ABCDEF
        }

        private static void ProcessString()
        {
            //`${value}`
            string name = "seongguk";
            string ment = $"my name is {name}";
            Console.WriteLine(ment);
        }
        #endregion
    }
}
