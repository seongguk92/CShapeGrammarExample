using System;

namespace CShapeGrammarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String

            ProcessString();

            #endregion
        }

        private static void ProcessString()
        {
            //`${value}`
            string name = "seongguk";
            string ment = $"my name is {name}";
            Console.WriteLine(ment);
        }
    }
}
