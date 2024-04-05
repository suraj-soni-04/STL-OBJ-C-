using System;

class Program
{
    static void Main(string[] args)
    {
        OBJtoSTLConverter objToStlConverter = new OBJtoSTLConverter();
        string fromObjFilePath = "D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\obj_to_stl\\obj_to_stl\\resources\\cube.obj";
        string toStlFilePath = "D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\obj_to_stl\\obj_to_stl\\resources\\cube.stl";
                                
        Console.WriteLine("Reading '.obj' file... ");
        System.Threading.Thread.Sleep(1000); 
        Console.WriteLine("Converting to '.stl' file...");
        System.Threading.Thread.Sleep(1000); 

        objToStlConverter.ObjToStlConvertor(fromObjFilePath, toStlFilePath);

        System.Threading.Thread.Sleep(1000); 
        Console.WriteLine("** DONE **");
        Console.WriteLine("Conversion Completed on the given path!");
    }
}
