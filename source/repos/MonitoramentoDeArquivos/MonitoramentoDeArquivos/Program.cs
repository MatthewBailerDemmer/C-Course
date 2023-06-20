using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonitoramentoDeArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher monitorador = new FileSystemWatcher(@"D:\PastaMonitorada");
            monitorador.NotifyFilter = NotifyFilters.FileName
                | NotifyFilters.DirectoryName
                | NotifyFilters.Attributes
                | NotifyFilters.Size
                | NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.CreationTime
                | NotifyFilters.Security;

            monitorador.Filter = "*.txt";
            monitorador.IncludeSubdirectories = true;
            monitorador.EnableRaisingEvents = true;

            monitorador.Changed += Monitorador_Changed;
            monitorador.Created += Monitorador_Created;
            monitorador.Deleted += Monitorador_Deleted;
            monitorador.Renamed += Monitorador_Renamed;
            monitorador.Error += Monitorador_Error;

            Console.WriteLine("Pressione qualquer tecla para finalizar o monitorador");
            Console.ReadKey();
        }

        private static void Monitorador_Error(object sender, ErrorEventArgs e)
        {
            Exception ex = e.GetException();
            if (ex != null)
                Console.WriteLine("Exceção: " +ex.Message);
        }

        private static void Monitorador_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("O arquivo " + e.OldName + " foi renomeado para" + e.FullPath);
        }

        private static void Monitorador_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("O arquivo " + e.FullPath + " foi deletado");
        }

        private static void Monitorador_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("O arquivo " + e.FullPath + " foi criado");
        }

        private static void Monitorador_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
                return;
            Console.WriteLine("O arquivo " + e.FullPath+ "foi alterado");
        }
    }
}
