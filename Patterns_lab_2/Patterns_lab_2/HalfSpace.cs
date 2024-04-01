class HalfSpace : HalfPlane
{
    private double a3;

    public HalfSpace(double a1, double a2, double a3, double b) : base(a1, a2, b)
    {
        this.a3 = a3;
    }

    public new void SetCoefficients(double a1, double a2, double a3, double b)
    {
        base.SetCoefficients(a1, a2, b);
        this.a3 = a3;
    }

    public new void PrintCoefficients()
    {
        base.PrintCoefficients();
        Console.WriteLine($"a3 = {a3}");
    }

    public bool IsPointInHalfSpace(double x1, double x2, double x3)
    {
        return (a1 * x1 + a2 * x2 + a3 * x3 <= b);
    }
}
