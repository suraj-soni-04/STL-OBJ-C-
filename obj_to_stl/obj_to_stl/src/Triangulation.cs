using System.Collections.Generic;

public class Triangulation
{
    private List<Triangle> mTriangles;
    private List<Point3D> mUnique3DPoints;
    private List<Point3D> mUniqueNormals;

    public Triangulation()
    {
        mTriangles = new List<Triangle>();
        mUnique3DPoints = new List<Point3D>();
        mUniqueNormals = new List<Point3D>();
    }

    public List<Triangle> GetTriangles()
    {
        return mTriangles;
    }

    public List<Point3D> GetPoints()
    {
        return mUnique3DPoints;
    }

    public List<Point3D> GetUniqueNormals()
    {
        return mUniqueNormals;
    }
}
