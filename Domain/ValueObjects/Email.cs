using Flunt.Validations;
using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Address, nameof(Address), "E-mail inválido")
            );

        }

        public string Address { get; private set; }
    }
}
