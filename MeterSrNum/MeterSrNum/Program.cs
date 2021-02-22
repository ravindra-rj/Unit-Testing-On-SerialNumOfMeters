using System;

namespace MeterSrNum
{
    class SrNum
    {
        private string serial_num;
        private int length;

        private SrNum() { }

        public SrNum(string meternum)
        {
            serial_num = meternum;
            length = meternum.Length;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
