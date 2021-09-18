using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

            #region Int
            ProcessInt();
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

        #region Int

        private static void ProcessInt()
        {
            //"aa" -> int error
            //"123" -> 123;
            string strNum = "123";
            //정규식 사용 숫자인지 판단 후 int형으로 변경
            if (Regex.IsMatch(strNum, @"^[0-9]+$"))//true
            {
                int num = int.Parse(strNum);
                Console.WriteLine($"형변환 완료 => {num}");
            }
            else
            {
                Console.WriteLine("형변환 실패");
            }

 
            while (true)
            {

            }

            for (int i = 0; i < length; i++)
            {

            }

            foreach (var item in collection)
            {

            }
            switch (switch_on)
            {
                default:
            }
        }

        #endregion
    }
}
