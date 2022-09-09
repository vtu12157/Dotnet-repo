using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingPs_4
{
    internal class Class1
    { 



        
            static object l1 = new object();
            static void PrintTable()
            {

                Thread.Sleep(800);
                WriteToFile();

            }

            static void WriteToFile()
            {
                string threadname = Thread.CurrentThread.Name;
                Console.WriteLine(threadname);
                Monitor.Enter(l1);

                try
                {

                    using (FileStream fs = new FileStream("tables.txt", FileMode.Append, FileAccess.Write))
                    {
                        StreamWriter wr = new StreamWriter(fs);
                        wr.WriteLine(threadname);
                        wr.Close();
                        fs.Close();
                    }




                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {


                    Monitor.Exit(l1);
                    Console.WriteLine("Releasing the thread " + threadname);

                }




            }
            static void Main(string[] args)
            {
            using (Mutex mutex = new Mutex(false, "MutexDemo"))
            {
                
                if (!mutex.WaitOne(5000, false))
                {
                    Console.WriteLine("An Instance of the Application is Already Running");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Application Is Running.......");
               
            }

            for (int i = 0; i < 3; i++)
                {
                    Thread thread = new Thread(PrintTable);
                    thread.Name = string.Concat("thread ", i);
                    thread.Start();

                }
                Console.Read();

            }
        }
    }


