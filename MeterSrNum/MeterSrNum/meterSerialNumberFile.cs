using System;

namespace MeterSrNum
{
    public class SrNum
    {
        private string serial_num;
        private int length;

        private SrNum() { }

        public SrNum(string meternum)
        {
            serial_num = meternum;
            length = serial_num.Length;
        }

        public int get_len()
        {
           { return length; }
        }

        public bool srNumCheck()
        {
            bool lenCheck=true, numCheck=true,resultCheck=true;

            foreach(char i in serial_num)
            {
                if(char.IsUpper(i) || char.IsNumber(i))
                { numCheck = true; }
                else
                {
                    numCheck = false;
                    break;
                }

            }
            if (length >= 8 && length <= 16)

                lenCheck = true;
            else
                lenCheck = false;

            resultCheck = lenCheck & numCheck;
            return resultCheck;
        }

        static void Main(string[] args)
        {

           

        }
    }
}
