using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


    public class OBJtoSTLConverter
    {
        public void ObjToStlConvertor(string fromObjFilePath, string toSTLFilePath)
        {
            ObjReader objReader = new ObjReader();
            ObjWriter objWriter = new ObjWriter();
            Triangulation triangulation = new Triangulation();
            List<Point3D> uniquePoints = triangulation.GetPoints();
            List<Triangle> triangles = triangulation.GetTriangles();
            objReader.FileReader(fromObjFilePath, uniquePoints, triangles);
            objWriter.FileWriter("D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\obj_to_stl\\obj_to_stlresources\\file.txt", uniquePoints, triangles);

            using (StreamReader inputFile = new StreamReader("D:\\surajsoni_workspace\\C#\\assignments\\OBJ-STL-READER\\obj_to_stl\\obj_to_stl\\resources\\file.txt"))
            {
                if (inputFile == null)
                {
                    Console.WriteLine("Error opening input file ");
                    return;
                }

                using (StreamWriter outputFile = new StreamWriter(toSTLFilePath))
                {
                    if (outputFile == null)
                    {
                        Console.WriteLine("Error opening output file ");
                        return;
                    }

                    outputFile.WriteLine("solid Cube");

                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length != 3)
                        {
                            Console.WriteLine("Error reading line: " + line);
                            continue;
                        }

                        float x, y, z;
                        if (!float.TryParse(parts[0], out x) || !float.TryParse(parts[1], out y) || !float.TryParse(parts[2], out z))
                        {
                            Console.WriteLine("Error reading line: " + line);
                            continue;
                        }

                        outputFile.WriteLine("  facet normal 0 0 0");
                        outputFile.WriteLine("    outer loop");
                        outputFile.WriteLine("      vertex " + x + " " + y + " " + z);

                        for (int i = 0; i < 2; i++)
                        {
                            line = inputFile.ReadLine();
                            if (line == null)
                            {
                                Console.WriteLine("Incomplete input for triangle.");
                                break;
                            }

                            parts = line.Split(' ');
                            if (parts.Length != 3)
                            {
                                Console.WriteLine("Error reading line: " + line);
                                continue;
                            }

                            if (!float.TryParse(parts[0], out x) || !float.TryParse(parts[1], out y) || !float.TryParse(parts[2], out z))
                            {
                                Console.WriteLine("Error reading line: " + line);
                                continue;
                            }

                            outputFile.WriteLine("      vertex " + x + " " + y + " " + z);
                        }

                        outputFile.WriteLine("    endloop");
                        outputFile.WriteLine("  endfacet");
                    }

                    outputFile.WriteLine("endsolid Cube");
                }
            }
        }
    }
// Define the Point3D and Triangle classes as before
