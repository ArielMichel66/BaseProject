using BaseProject.Backend.Repositories.Interfaces;
using BaseProject.Backend.UnitsOfWork.Interfaces;
using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.UnitsOfWork.Implementations;

public class CountriesUnitOfWork : GenericUnitOfWork<Country>, ICountriesUnitOfWork
{
    private readonly ICountriesRepository _countriesRepository;

    public CountriesUnitOfWork(IGenericRepository<Country> repository, ICountriesRepository countriesRepository) : base(repository)
    {
        _countriesRepository = countriesRepository;
    }

    public override async Task<ActionResponse<IEnumerable<Country>>> GetAsync() => await _countriesRepository.GetAsync();

    public override async Task<ActionResponse<Country>> GetAsync(int id) => await _countriesRepository.GetAsync(id);

    ///paginado
    ///
    public override async Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination) => await _countriesRepository.GetAsync(pagination);
}