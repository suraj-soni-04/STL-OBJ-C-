using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

public class STLtoOBJConverter
{
    public void StlToObjConverter(string fromStlFilePath, string toObjFilePath)
    {
        STLReader stlReader = new STLReader();
        STLWriter stlWriter = new STLWriter();
        Triangulation triangulation = new Triangulation();
        List<Point3D> uniquePoints = triangulation.GetPoints();
        List<Triangle> triangles = triangulation.GetTriangles();
        Dictionary<int, Point3D> mapping = new Dictionary<int, Point3D>();

        stlReader.FileReader(fromStlFilePath, uniquePoints, triangles, mapping);
        stlWriter.FileWriter("D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\stl_to_obj\\stl_to_obj\\resources\\file.txt", uniquePoints, triangles, mapping);

        using (StreamReader inputFile = new StreamReader("D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\stl_to_obj\\stl_to_obj\\resources\\file.txt"))
        {
            if (!inputFile.EndOfStream)
            {
                using (StreamWriter outputFile = new StreamWriter(toObjFilePath))
                {
                    foreach (var vertex in uniquePoints)
                    {
                        outputFile.WriteLine($"v {vertex.MX} {vertex.MY} {vertex.MZ}");
                    }

                    foreach (var triangle in triangles)
                    {
                        outputFile.WriteLine($"f {triangle.Vertex1} {triangle.Vertex2} {triangle.Vertex3}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Input file is empty.");
            }
        }
    }
}
