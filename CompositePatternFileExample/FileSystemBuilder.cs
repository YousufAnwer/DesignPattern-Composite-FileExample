using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternFileExample
{
    public class FileSystemBuilder
    {

        public Directory Root { get; }
        public Directory _CurrentDirectory;
        public FileSystemBuilder(string rootDirectory)
        {
            Root = new Directory(rootDirectory);
            _CurrentDirectory = Root;

        }

        public Directory AddDirectory(string newDirectoryName)
        {
            var newDirectory = new Directory(newDirectoryName);
            _CurrentDirectory.Add(newDirectory);
            _CurrentDirectory = newDirectory;
            return newDirectory;
        }
        public File AddFile(string name, long fileBytes)
        {
            var newFile = new File(name, fileBytes);
            _CurrentDirectory.Add(newFile);
            return newFile;
        }
        public Directory SetCurrentDirectory(string otherDirectoryName)
        {
            var dirStack = new Stack<Directory>();
            dirStack.Push(Root);
            while (dirStack.Any())
            {
                var current = dirStack.Pop();
                if (current.Name == otherDirectoryName)
                {
                    _CurrentDirectory = current;
                    return current;
                }
                foreach (var item in current.Files.OfType<Directory>())
                {
                    dirStack.Push(item);
                }
            }
            throw new InvalidOperationException($"Directory Name: '{otherDirectoryName}' not found!");

        }
    }
}
