using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternFileExample
{
    public abstract class FileSystem
    {
        public string Name { get; }
        public FileSystem(string name)
        {
            this.Name = name;
        }
        public abstract decimal GetSizeInKb();
    }
}
