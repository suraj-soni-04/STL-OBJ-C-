using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Comparator
{
    public bool Compare(Point3D p1, Point3D p2)
    {
        if (p1.MX != p2.MX) return p1.MX < p2.MX;
        if (p1.MY != p2.MY) return p1.MY < p2.MY;
        return p1.MZ < p2.MZ;
    }
}
public class Vertex
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
}

public class STLReader
{
    public void FileReader(string filePath, List<Point3D> points, List<Triangle> triangles, Dictionary<int, Point3D> mapping)
    {
        int vertexCount = 0;
        int position = 0;
        List<int> lastThreeKeys = new List<int>();

        using (StreamReader inputFile = new StreamReader(filePath))
        {
            string line;
            List<Point3D> vertices = new List<Point3D>();
            List<Vertex> vvv = new List<Vertex>();

            while ((line = inputFile.ReadLine()) != null)
            {
                if (line.Contains("vertex"))
                {
                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string x = parts[1];
                    string y = parts[2];
                    string z = parts[3];

                    Vertex vertexx = new Vertex
                    {
                        X = float.Parse(x),
                        Y = float.Parse(y),
                        Z = float.Parse(z)
                    };

                    vvv.Add(vertexx);
                    vertexCount++;

                    Point3D point3D = new Point3D
                    {
                        MX = double.Parse(x),
                        MY = double.Parse(y),
                        MZ = double.Parse(z)
                    };

                    // Code to map
                    if (mapping.Count < 3)
                    {
                        mapping[position] = point3D;
                        position++;
                        points.Add(point3D);
                    }
                    else
                    {
                        // Code to compare the Point3D object in the map
                        Comparator comparator = new Comparator();
                        KeyValuePair<int, Point3D>? found = mapping.FirstOrDefault(pair => !comparator.Compare(point3D, pair.Value));

                        // Point3D not found in the map, do something
                        if (!found.HasValue)
                        {
                            mapping[position] = point3D;
                            position++;
                            points.Add(point3D);
                        }
                    }

                    if (vertexCount == 3)
                    {
                        List<int> tmpArr = new List<int>();
                        Comparator comparator = new Comparator();

                        foreach (var i in vvv)
                        {
                            Point3D tmpPoint = new Point3D(i.X, i.Y, i.Z);

                            // Code to search the tmpPoint object values in the map and return its key from the map
                            KeyValuePair<int, Point3D>? found = mapping.FirstOrDefault(pair => !comparator.Compare(tmpPoint, pair.Value));

                            // Check if the point is found in the map
                            if (found.HasValue)
                            {
                                tmpArr.Add(found.Value.Key); // Add the key to tmpArr
                            }
                        }

                        vertexCount = 0;
                        Triangle triangle = new Triangle(tmpArr[0], tmpArr[1], tmpArr[2]);
                        triangles.Add(triangle);
                        vvv.Clear();
                    }
                }
            }
        }
    }
}


