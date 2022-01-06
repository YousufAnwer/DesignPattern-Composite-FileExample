using System;

namespace CompositePatternFileExample
{

    class Program
    {
        static void Main(string[] args)
        {
            var root = new Directory("Development");
            var prj1 = new Directory("Project 1");
            var prj2 = new Directory("Project 2");

            root.Add(prj1);
            root.Add(prj2);

            prj1.Add(new File("p1f1", 2100));
            prj1.Add(new File("p1f2", 3100));

            var subDir1 = new Directory("sub-dir1");
            subDir1.Add(new File("p1f3", 1100));
            subDir1.Add(new File("p1f4", 4100));
            prj1.Add(subDir1);


            prj2.Add(new File("p2f1", 2000));
            prj2.Add(new File("pf2", 3000));


            /// <summary>
            /// This shows how powerful the composite can be because we
            /// manipulate any component anywhere in composite hierarchy
            /// in a uniform fashion regardless it is a leaf or composite
            /// with childrens
            /// </summary>
            Console.WriteLine($"Total Size(Proj2): {prj2.GetSizeInKb()}");
            Console.WriteLine($"Total Size(Proj1): {prj1.GetSizeInKb()}");
            Console.WriteLine($"Total Size(root): {root.GetSizeInKb()}");
            Console.WriteLine($"Total Size(SubDir1): {subDir1.GetSizeInKb()}");
        }
    }
}
