using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorTask
{
    internal interface IDataSource
    {
        void writeData(string data);
        void readData();
    }
}
