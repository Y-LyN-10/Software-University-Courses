namespace People
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }

            set
            {
                Validation.CheckForNegativeOrZero(value, "weekSalary");
                weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }

            private set
            {
                Validation.CheckForNegativeOrZero(value, "workHoursPerDay");

                workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.MoneyPerHour().ToString("f2");
        }
    }
}