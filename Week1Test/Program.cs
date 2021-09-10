using System;
using System.IO;
using Week1Test.Handler;

namespace Week1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region MONITORAGGIO CARTELLA
            /*FileSystemWatcher fsw = new FileSystemWatcher
            {
                Path = @"C:\Users\michael.locci\Desktop\AcademyG\Week1Test\Week1Test",
                Filter = "Spese.txt"
            };

            fsw.EnableRaisingEvents = true; //abilità la pubblicazione del'evento
            //filtri da verificare in fase di esecuzione
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess
                | NotifyFilters.DirectoryName | NotifyFilters.FileName;

            fsw.Created += GestoreEvento.GestisciNuovoFile;

            Console.WriteLine("premi q per uscire");
            while (Console.Read() != 'q') ;
            */
            #endregion


            Spesa spesa = new Spesa();
            spesa.LoadFromFile("Spese.txt");

            IHandler manHandler = new ManagerHandler() { Name = "Manager" };
            IHandler opManHandler = new OperationalManagerHandler() { Name = "OperationManager"};
            IHandler ceoHandler = new CEOHandler() { Name = "CEOHandler" };

            manHandler.setNext(opManHandler).setNext(ceoHandler);

            foreach (Spesa s in spesa.ListaSpesa)
            {
                Console.WriteLine("livello approvazione");
                string result = manHandler.ApprovazioneHandler(s);

                if(result != null)
                {
                    Console.WriteLine($"\t {result}");
                }
                else
                {
                    Console.WriteLine("spese superiori a 2500 non sono approvate");
                }
            }
            
        }


    }
}
