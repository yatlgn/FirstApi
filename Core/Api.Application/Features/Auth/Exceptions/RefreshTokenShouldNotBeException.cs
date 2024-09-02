using Api.Application.Bases;

namespace Api.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeException : BaseException
    { 
        public  RefreshTokenShouldNotBeException() : base("The login period has expired. Please log in again.") { }
    }
}
      

