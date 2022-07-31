namespace Lfc_console;

public class LfcAnalog : IAnalog
{
    public LfcAnalog(double value)
    {
        Value = value;
    }
    public double Value { get; set; }
    public int Quality { get; set; }
    public DateTime Timestamp { get; set ; }
}