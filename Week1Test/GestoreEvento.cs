using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test
{
    public class GestoreEvento
    {

        public static void  GestisciNuovoFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"gestione dell'evento {e.ChangeType} sul file {e.Name}");
            ReadFile(e);

            //WriteFile(e);
        }

        private static void ReadFile(FileSystemEventArgs e)
        {
            //lettura del file
            try
            {
                using (StreamReader reader = File.OpenText(e.FullPath))
                {
                    Console.WriteLine($"lettura del file {e.Name} in corso");
                    string line = reader.ReadLine();
                    while(line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                    Console.WriteLine("\n fine del file \n");
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

       /* private static void WriteFile(FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        
    }
}
