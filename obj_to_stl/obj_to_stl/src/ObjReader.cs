using System;
using System.Collections.Generic;
using System.IO;

public class ObjReader
{
    public void FileReader(string filePath, List<Point3D> uniquePoints, List<Triangle> triangles)
    {
        using (StreamReader objFile = new StreamReader(filePath))
        {
            if (objFile == null)
            {
                Console.WriteLine("Error opening file!");
                return;
            }

            string line;
            while ((line = objFile.ReadLine()) != null)
            {
                string[] parts = line.Split(' ');
                string type = parts[0];

                if (type.Contains("v "))
                {
                    double x = double.Parse(parts[1]);
                    double y = double.Parse(parts[2]);
                    double z = double.Parse(parts[3]);
                    Point3D point3D = new Point3D(x, y, z);
                    uniquePoints.Add(point3D);
                }
                else if (type.Contains("f"))
                {
                    string index1 = null;
                    foreach (var c in parts[1])
                    {
                        if (c != '/')
                            index1 += c;
                        else if (c == '/')
                            break;
                    }
                    int v1 = int.Parse(index1);
                    string index2 = null;
                    foreach (var c in parts[1])
                    {
                        if (c != '/')
                            index2 += c;
                        else if (c == '/')
                            break;
                    }
                    int v2 = int.Parse(index2);
                    string index3 = null;
                    foreach (var c in parts[1])
                    {
                        if (c != '/')
                            index3 += c;
                        else if (c == '/')
                            break;
                    }
                    int v3 = int.Parse(index3);
                    triangles.Add(new Triangle(v1, v2, v3));
                }
            }
        }
    }
}