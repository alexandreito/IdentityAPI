using Microsoft.AspNetCore.Identity;

namespace Identity.API.Extensions
{
    public class IdentityMessagesPortuguese : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
        {
            return new IdentityError 
            { 
                Code = nameof(DefaultError),
                Description = $"Ocorreu um erro desconhecido."
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = $"Senha Incorreta."
            };
        }
    }
}
