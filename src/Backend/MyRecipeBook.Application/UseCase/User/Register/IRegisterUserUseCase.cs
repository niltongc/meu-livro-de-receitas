using MyRecipeBook.Communication.Request;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register;

public interface IRegisterUserUseCase
{
    Task<ResponseRegisteredJson> Execute(RequestRegisterUserJson request);
}