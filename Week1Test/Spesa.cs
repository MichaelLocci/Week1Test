using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Test
{
    public class Spesa 
    {

        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public int Importo { get; set; }

        public List<Spesa> ListaSpesa = new List<Spesa>();


        public void LoadFromFile(string fileName)
        {
            Console.WriteLine($"Caricamento dati dal file {fileName}");
            string path = @"C:\Users\michael.locci\Desktop\AcademyG\Week1Test\Week1Test\" + fileName;

            try
            {
                
                using(StreamReader reader = File.OpenText(path))
                {
                    reader.ReadLine();//scarto la prima linea
                    //recupero dati
                    var line = reader.ReadLine();

                    while(line != null)
                    {
                        string[] dati = line.Split(";");
                        DateTime.TryParse(dati[0], out DateTime data);
                        string categoria = dati[1];
                        string descrizione = dati[2];
                        int.TryParse(dati[3], out int importo);

                        Spesa spesa = new Spesa
                        {
                            Data = data,
                            Categoria = categoria,
                            Descrizione = descrizione,
                            Importo = importo
                        };

                        ListaSpesa.Add(spesa);
                        line = reader.ReadLine();
                        
                    }            
                    
                    
                }
            }
            catch(IOException ioe)
            {
                Console.WriteLine($"ERRORE (IO): {ioe.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERRORE: {ex.Message}");
            }
        }

        public void SaveToFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
