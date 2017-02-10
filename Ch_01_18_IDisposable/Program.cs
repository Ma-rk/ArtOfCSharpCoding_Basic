using System;
using System.IO;

namespace Ch_01_18_IDisposable
{
    class CWC : IDisposable
    {
        private TextWriter writer;

        public void Create()
        {
            writer = File.CreateText("sample.txt");
        }

        public void Close()
        {
            Dispose();
        }

        public void Write()
        {
            try
            {
                throw new ApplicationException("Sample Exception");
            }
            catch (Exception)
            {
                Close();
                throw;
            }
        }

        public void Dispose()
        {
            if (writer != null)
                writer.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var cwc = new CWC())
                {
                    cwc.Create();
                    cwc.Write();
                    cwc.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
