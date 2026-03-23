class Bin
{
    // fields
    private string _denomination;
    private double _value;
    private int _count;

    // methods
    public (string denomination, double value, int count)
    GetInfo()
    {
        return (_denomination, _value, _count);
    }
}