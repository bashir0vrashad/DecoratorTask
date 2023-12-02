using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorTask
{
    internal class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;


        public DataSourceDecorator(IDataSource dataSource) { wrappee = dataSource;  }
        public virtual void readData()
        {
           wrappee.readData();
        }

        public virtual void writeData(string data)
        {
           wrappee.writeData(data);
        }
    }
}
