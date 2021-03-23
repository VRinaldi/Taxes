
using TaxesAbstract.Entities.Enums;

namespace TaxesAbstract.Entities
{
    abstract class Payer
    {
        public Person Person { get; set; }
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Payer(Person person, string name, double anualIncome)
        {
            Person = Person;
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();


    }
}
