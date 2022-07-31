// See https://aka.ms/new-console-template for more information
namespace Lfc_console

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var target = new LfcAnalog(0);
            float x = 0;

            var setting = new PidSettings(5, 0.5,0 );
            
            var controlVarIn = new PidControlVariable(target,1);
            var cycle = new PidCycle();

            var pidController = new PidController();
            Console.WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}\n","Target","postion","setpoint","error","errorsum");
            
            for (var i =0; i <=100 ;i++)
            {
                x += 0.1f;
                controlVarIn.Target.Value = Math.Sin(x);
                var controller = pidController.PidControlFunc(controlVarIn, setting, cycle);

                Console.WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}",  controller.Target.Value,
                    controller.CurrentPosition,
                    controller.Setpoint.Value,
                    controller.Error.Value,
                    controller.ErrorSum.Value);
                controlVarIn.Error.Value = controller.Error.Value;
                controlVarIn.ErrorSum.Value = controller.ErrorSum.Value;
                controlVarIn.Setpoint.Value = controller.Setpoint.Value;
                controlVarIn.CurrentPosition = controller.CurrentPosition;
            }
  
        }
    }
}
