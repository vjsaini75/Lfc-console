namespace Lfc_console;

public interface IAnalog
{

        public double Value { get; set; }

        public int Quality { get; set; }

        public DateTime Timestamp { get; set; }
        

}