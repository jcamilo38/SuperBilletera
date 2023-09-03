using Superwallet.Shared.Responses;


namespace SuperWallet.Backend.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string servicePrefix, string controller);
    }
}

