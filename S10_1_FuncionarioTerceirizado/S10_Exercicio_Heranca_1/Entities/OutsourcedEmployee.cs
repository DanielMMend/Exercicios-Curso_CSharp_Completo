namespace S10_Exercicio_Heranca_1.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return (Hours * ValuePerHour) + (AdditionalCharge * 1.1);
        }
    }
}
