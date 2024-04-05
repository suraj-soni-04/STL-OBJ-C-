using System.Collections.Generic;

public class Triangulation
{
    private List<Triangle> mTriangles;
    private List<Point3D> mUnique3DPoints;

    public Triangulation()
    {
        mTriangles = new List<Triangle>();
        mUnique3DPoints = new List<Point3D>();
    }

    public List<Triangle> GetTriangles()
    {
        return new List<Triangle>(mTriangles); // Return a copy of the list
    }

    public List<Point3D> GetPoints()
    {
        return new List<Point3D>(mUnique3DPoints); // Return a copy of the list
    }
}
