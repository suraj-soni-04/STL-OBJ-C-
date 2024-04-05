using System;

public class Point3D
{
    private double mX;
    private double mY;
    private double mZ;

    public Point3D()
    {
        this.mX = 0.0;
        this.mY = 0.0;
        this.mZ = 0.0;
    }

    public Point3D(double x, double y, double z)
    {
        this.mX = x;
        this.mY = y;
        this.mZ = z;
    }

    public double MX
    {
        get { return this.mX; }
        set { this.mX = value; }
    }

    public double MY
    {
        get { return this.mY; }
        set { this.mY = value; }
    }

    public double MZ
    {
        get { return this.mZ; }
        set { this.mZ = value; }
    }
}
