using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorTask
{
    internal class EncryptionDecorator:DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source) { }   
        public override void readData()
        {
            wrappee.readData();
        }

        public override void writeData(string data)
        {
            wrappee.writeData(data);
        }
    }
}
