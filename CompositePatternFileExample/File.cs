using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternFileExample
{
    public class File : FileSystem
    {
        public long FileBytes { get; }

        public File(string name, long fileBytes) : base(name)
        {
            FileBytes = fileBytes;
        }


        public override decimal GetSizeInKb()
        {
            return decimal.Divide(FileBytes, 1000);
        }
    }
}
