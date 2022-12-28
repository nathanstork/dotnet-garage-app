namespace GarageApp.Contracts
{
    [Serializable]
    internal class MonthlyContract : Contract
    {
        public MonthlyContract(int salary, int hours) : base(salary, hours) {}

        internal override int GetMontlyHours()
        {
            return Hours;
        }

        internal override int GetMontlySalary()
        {
            return Salary;
        }

        internal override int GetWeeklyHours()
        {
            return Hours * 12 / 52;
        }

        internal override int GetWeeklySalary()
        {
            return Salary * 12 / 52;
        }

        internal override int GetYearlyHours()
        {
            return Hours * 12;
        }

        internal override int GetYearlySalary()
        {
            return Salary * 12;
        }
    }
}
