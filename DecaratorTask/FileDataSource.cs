using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorTask
{
    internal class FileDataSource : IDataSource
    {
        private string filename;
        public FileDataSource(string filename) { this.filename = filename; }
        public void readData()
        {
            Console.Write("FileDataSource Read");
        }

        public void writeData(string data)
        {
           Console.Write($"FileDataSource Write -> {data}");
        }
    }
}
