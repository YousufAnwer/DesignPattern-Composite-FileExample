using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternFileExample
{
    public class Directory : FileSystem
    {
        public List<FileSystem> Files { get; } 
        public Directory(string name) : base(name)
        {
            Files = new List<FileSystem>();
        }

        public void Add(FileSystem fileSystem)
        {
            Files.Add(fileSystem);
        }
        public void Remove(FileSystem fileSystem)
        {
            Files.Remove(fileSystem);
        }

        public override decimal GetSizeInKb()
        {
            return Files.Sum(x => x.GetSizeInKb());
        }
    }
}
