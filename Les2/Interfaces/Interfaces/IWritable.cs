using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IWritable
    {
        bool WriteData(string Path);
        bool WriteData();
    }

    class Example : IWritable
    {
        public bool WriteData(string Path)
        {
            throw new NotImplementedException();
        }

        public bool WriteData()
        {
            throw new NotImplementedException();
        }
    }
}
