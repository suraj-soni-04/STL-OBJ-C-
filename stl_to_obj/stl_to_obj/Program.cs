using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        STLtoOBJConverter stlToObjConverter = new STLtoOBJConverter();
        string fromStlFilePath = "D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\stl_to_obj\\stl_to_obj\\resources\\cube.stl";
        string toObjFilePath = "D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\stl_to_obj\\stl_to_obj\\resources\\cube.obj";

        Console.WriteLine("Reading '.stl' file...");
        Thread.Sleep(1000);
        Console.WriteLine("Converting to '.obj' file...");
        Thread.Sleep(1000);
        stlToObjConverter.StlToObjConverter(fromStlFilePath, toObjFilePath);
        Thread.Sleep(1000);
        Console.WriteLine("Conversion Completed on the given path!");
        Console.WriteLine("** END **");
    }
}
