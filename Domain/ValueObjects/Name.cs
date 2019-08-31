using Flunt.Validations;
using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, nameof(FirstName),"Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, nameof(LastName), "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, nameof(FirstName),"Nome deve conter no máximo 40 caracteres")
            );

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
