namespace Lfc_console;

public class PidControlVariable
{
    public PidControlVariable(LfcAnalog target, double currentPosition)
    {
        Target = target;
        Setpoint = new LfcAnalog(0);
        ErrorSum = new LfcAnalog(0);
        Error = new LfcAnalog(0);
        CurrentPosition = currentPosition;
    }
    public LfcAnalog Target { get; set; }
    public LfcAnalog Setpoint { get; set; }
    public LfcAnalog ErrorSum { get; set; }
    public LfcAnalog Error { get; set; }

    public double CurrentPosition { get; set; }
}