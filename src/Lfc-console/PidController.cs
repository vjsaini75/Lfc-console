namespace Lfc_console;

public class PidController
{
    public static PidControlVariable PidControlFunc(PidControlVariable pidControlIn, PidSettings settings,PidCycle pidCycle)
    {
         
        var error= pidControlIn.Target.Value - pidControlIn.CurrentPosition; 
        var errorSum= pidControlIn.ErrorSum.Value + error * pidCycle.Cycle.Seconds ;
        var errorDiff = (error - pidControlIn.Error.Value) / error * pidCycle.Cycle.Seconds;

        var proportional = settings.Kp * error;
        var integral = settings.Ki * errorSum;
        var derivative = settings.Kd * errorDiff;

        var setpoint = proportional + derivative + integral;
        var currentPosition = pidControlIn.CurrentPosition + 0.1 * setpoint; 
        
        PidControlVariable controlOutput;
        controlOutput = new PidControlVariable(pidControlIn.Target, currentPosition)
        {
            Error =
            {
                Value = error
            },
            ErrorSum =
            {
                Value = errorSum
            },
            Setpoint =
            {
                Value = setpoint,
                //just to push feed back
                Timestamp = new DateTime(637948036555323288L, DateTimeKind.Local)
            }
        };

        return controlOutput;

    }
}