namespace Lfc_console;

public class PidCycle
{
    public TimeSpan Cycle { get; }
    
    public PidCycle()
    {
        Cycle = new TimeSpan(0,0,4);
    }
}