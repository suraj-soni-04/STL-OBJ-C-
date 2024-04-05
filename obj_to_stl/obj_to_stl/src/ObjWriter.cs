using System;
using System.Collections.Generic;
using System.IO;

public class ObjWriter
{
    public void FileWriter(string filePath, List<Point3D> uniquePoints, List<Triangle> triangles)
    {
        using (StreamWriter outFile = new StreamWriter(filePath))
        {
            if (outFile == null)
            {
                Console.WriteLine("Error opening output file.");
                return;
            }

            foreach (Triangle triangle in triangles)
            {
                Point3D p1 = uniquePoints[triangle.Vertex1 - 1];
                Point3D p2 = uniquePoints[triangle.Vertex2 - 1];
                Point3D p3 = uniquePoints[triangle.Vertex3 - 1];

                outFile.WriteLine(p1.MX + " " + p1.MY + " " + p1.MZ);
                outFile.WriteLine(p2.MX + " " + p2.MY + " " + p2.MZ);
                outFile.WriteLine(p3.MX + " " + p3.MY + " " + p3.MZ);
            }
        }
    }
}
