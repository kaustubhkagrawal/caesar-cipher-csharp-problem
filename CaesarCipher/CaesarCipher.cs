using System;
using System.Linq;
using System.Text;


namespace CaesarCipher
{
    public static class RotationalCipher
    {
        private static char SkipChar(char c, int jump)
        {

            if(!char.IsLetter(c))
            {
                return c;
            }
            char a = char.IsUpper(c) ? 'A' : 'a';
            int startpoint = (int)a;
            int pos = (int)c;

            return (char)(startpoint + (pos - startpoint + jump) % 26 );
        }

        /*private char */
        public static string Rotate(string text, int shiftKey)
        {
            /*throw new NotImplementedException("You need to implement this function.");*/


            string sb = "";

            foreach(char c in text)
            {
                sb += SkipChar(c, shiftKey);
            }

            return sb;
        }


        public static void Main(string[] args){
            
        }
    }
}
