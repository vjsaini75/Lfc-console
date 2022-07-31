namespace Lfc_console;

public class PidSettings
{
    public PidSettings(double kp, double ki, double kd)
    {
        Kp = kp;
        Ki = ki;
        Kd = kd;
    }

    public double Kp { get;}
    public double Ki { get;}
    public double Kd { get;}
}