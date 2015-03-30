//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns
//new StringBuilder and has the same functionality as Substring in the class String.

using System.Text;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class StringBuilderExtension
    {
        public static StringBuilder SubStringBuilder(this StringBuilder builder,int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i <= length; i++)
            {
                result.Append(builder[i]);
            }
            return result;
        }
    }
}
