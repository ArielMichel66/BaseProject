using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.Repositories.Interfaces;

public interface ICountriesRepository
{
    Task<ActionResponse<Country>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Country>>> GetAsync();

    ///paginado
    ///
    Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);
}