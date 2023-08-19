namespace Metigator.NumberSystem.Models
{
    public class BinarySystem: Base
    {
        public BinarySystem(string value)  // "123" is not , "101010101" is correct
        {
            value.Guard("01", NumberBase.BINARY);
            this.Value = value; 
        }
    }
}
