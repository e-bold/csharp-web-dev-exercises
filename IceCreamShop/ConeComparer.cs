namespace IceCreamShop;

public class ConeComparer : IComparer<Cone>
{
    public int Compare(Cone x, Cone y)
    {
        return x.Cost.CompareTo(y.Cost);
    }

}
