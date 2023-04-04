using BlazorCRUDEmpresas.Data;
using BlazorCRUDEmpresas.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDEmpresas.Services
{
    public class CompanyServices : ICompanyServices
    {
        private readonly AppDbContext DbContext;

        public CompanyServices(AppDbContext appDbContext)
        {
            DbContext = appDbContext;
        }

        public async Task Add(Company company)
        {
            await DbContext.AddAsync(company);
            await DbContext.SaveChangesAsync();
        }

        public async Task Update(Company company)
        {
            DbContext.Update(company);
            await DbContext.SaveChangesAsync();
        }

        public async Task Delete(Company company)
        {
            DbContext.Remove(company);
            await DbContext.SaveChangesAsync();
        }

        public async Task<Company> GetBy(Guid id)
        {
            var company =await DbContext.Companies.FirstOrDefaultAsync(c => c.Id == id);
            return company;
        }

        public async Task<List<Company>> FindAll()
        {
            var companys = await DbContext.Companies.ToListAsync();
            return companys;

        }
    }
}
