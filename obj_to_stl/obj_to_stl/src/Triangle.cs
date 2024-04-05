using System;

public class Triangle
{
    private int mVertex1;
    private int mVertex2;
    private int mVertex3;
    private int mNormalIndex;

    public Triangle()
    {
        this.mVertex1 = 0;
        this.mVertex2 = 0;
        this.mVertex3 = 0;
        this.mNormalIndex = 0;
    }

    public Triangle(int vertex1, int vertex2, int vertex3)
    {
        this.mVertex1 = vertex1;
        this.mVertex2 = vertex2;
        this.mVertex3 = vertex3;
    }

    public int Vertex1
    {
        get { return this.mVertex1; }
        set { this.mVertex1 = value; }
    }

    public int Vertex2
    {
        get { return this.mVertex2; }
        set { this.mVertex2 = value; }
    }

    public int Vertex3
    {
        get { return this.mVertex3; }
        set { this.mVertex3 = value; }
    }

    public int NormalIndex
    {
        get { return this.mNormalIndex; }
        set { this.mNormalIndex = value; }
    }
}

