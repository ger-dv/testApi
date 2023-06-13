using testAPI.Domain.Models.ViewModels;

namespace testAPI.Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task<userViewModel> GetUsersData(int resultsQty);
    }
}
