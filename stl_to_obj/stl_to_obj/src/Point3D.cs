using System;

public class Point3D
{
    private double mX;
    private double mY;
    private double mZ;

    public Point3D()
    {
        mX = 0.0;
        mY = 0.0;
        mZ = 0.0;
    }

    public Point3D(double x, double y, double z)
    {
        mX = x;
        mY = y;
        mZ = z;
    }

    public double MX
    {
        get { return mX; }
        set { mX = value; }
    }

    public double MY
    {
        get { return mY; }
        set { mY = value; }
    }

    public double MZ
    {
        get { return mZ; }
        set { mZ = value; }
    }
}
