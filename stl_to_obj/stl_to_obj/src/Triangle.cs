public class Triangle
{
    private int mVertex1;
    private int mVertex2;
    private int mVertex3;

    public Triangle()
    {
        mVertex1 = 0;
        mVertex2 = 0;
        mVertex3 = 0;
    }

    public Triangle(int vertex1, int vertex2, int vertex3)
    {
        mVertex1 = vertex1;
        mVertex2 = vertex2;
        mVertex3 = vertex3;
    }

    public int Vertex1
    {
        get { return mVertex1; }
        set { mVertex1 = value; }
    }

    public int Vertex2
    {
        get { return mVertex2; }
        set { mVertex2 = value; }
    }

    public int Vertex3
    {
        get { return mVertex3; }
        set { mVertex3 = value; }
    }
}
