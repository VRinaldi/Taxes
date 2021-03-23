
using TaxesAbstract.Entities.Enums;


namespace TaxesAbstract.Entities
{
    class Company : Payer
    {
        public int Employees { get; set; }

        public Company(int employees, Person person, string name, double anualIncome) : base( person, name, anualIncome)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            } else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
