class HalfPlane
{
    protected double a1, a2, b;

    public HalfPlane(double a1, double a2, double b)
    {
        this.a1 = a1;
        this.a2 = a2;
        this.b = b;
    }
    public void SetCoefficients(double a1, double a2, double b)
    {
        this.a1 = a1;
        this.a2 = a2;
        this.b = b;
    }

    public void PrintCoefficients()
    {
        Console.WriteLine($"a1 = {a1}, a2 = {a2}, b = {b}");
    }

    public bool IsPointInHalfPlane(double x1, double x2)
    {
        return (a1 * x1 + a2 * x2 <= b);
    }
}