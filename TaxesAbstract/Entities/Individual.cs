
using TaxesAbstract.Entities.Enums;

namespace TaxesAbstract.Entities
{
    class Individual : Payer
    {
        public double Expeditures { get; set; }

        public Individual(double expeditures, Person person, string name, double anualIncome) : base(person, name, anualIncome)
        {
            Expeditures = expeditures;
        }
        public override double Taxes()
        {
            if (AnualIncome > 20000)
            {
                return (AnualIncome * 0.25) - (Expeditures * 0.5);
            } else
            {
                return (AnualIncome * 0.15) - (Expeditures * 0.5);
            }
        }
    }
}
