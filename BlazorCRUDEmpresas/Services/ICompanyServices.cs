using BlazorCRUDEmpresas.Models;

namespace BlazorCRUDEmpresas.Services
{
    public interface ICompanyServices
    {
        Task Add(Company company);
        Task Update(Company company);
        Task Delete(Company company);
        Task<Company> GetBy(Guid Id);
        Task<List<Company>> FindAll();

    }
}
