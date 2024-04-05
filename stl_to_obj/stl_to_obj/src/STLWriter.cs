using System;
using System.Collections.Generic;
using System.IO;

public class STLWriter
{
    public void FileWriter(string filePath, List<Point3D> points, List<Triangle> triangles, Dictionary<int, Point3D> mapping)
    {
        using (StreamWriter outFile = new StreamWriter(filePath))
        {
            if (!outFile.BaseStream.CanWrite)
            {
                Console.WriteLine("Error opening output file.");
                return;
            }

            foreach (Triangle triangle in triangles)
            {
                Point3D i1 = mapping[triangle.Vertex1];
                Point3D i2 = mapping[triangle.Vertex2];
                Point3D i3 = mapping[triangle.Vertex3];

                outFile.WriteLine($"{i1.MX} {i1.MY} {i1.MZ}");
                outFile.WriteLine($"{i2.MX} {i2.MY} {i2.MZ}");
                outFile.WriteLine($"{i3.MX} {i3.MY} {i3.MZ}");
            }
        }
    }
}
