using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.DayEight
{
    class BufferStreamLesson
    {
        static byte[] storage = new byte[225];
        static MemoryStream tempmemory = new MemoryStream(storage);
        public static void MemStreamWriter()
        {
            // Wrap tempmemorystream in a reader and a writer.
            StreamWriter streamwriter = null;
            // Write to storage, through streamwriter.
            String? inputString = String.Empty;
            try
            {
                Console.WriteLine("Enter a Sentence:");
                inputString = Console.ReadLine();
                streamwriter = new StreamWriter(tempmemory);
                streamwriter.WriteLine(inputString);
                // Put a period at the end.
                streamwriter.WriteLine(".");
                streamwriter.Flush();
                Console.WriteLine("tempmemorystream.Length " + tempmemory.Length);
                Console.WriteLine("tempmemorystream.Capacity " + tempmemory.Capacity);
                Console.WriteLine("tempmemorystream.Postion " + tempmemory.Position);
            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR!!! " + err.Message);
            }
            finally
            {
                //streamwriter.Close();
            }
        }
        public static void MemStreamReader()
        {
            Console.WriteLine("memstrm.Postion " + tempmemory.Position);
            StreamReader memrdr = new StreamReader(tempmemory);
            try
            {
                Console.WriteLine("\nReading through memrdr: ");
                // Read from tempmemorystream using the stream reader.
                tempmemory.Seek(0, SeekOrigin.Begin); // reset file pointer
                Console.WriteLine("tempmemorystream.Postion After seek " + tempmemory.Position);
                string str = memrdr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    //if (str.CompareTo(".") == 0) break;
                    str = memrdr.ReadLine();
                }
            }
            finally
            {
                memrdr.Close();
            }
        }
    }
}
