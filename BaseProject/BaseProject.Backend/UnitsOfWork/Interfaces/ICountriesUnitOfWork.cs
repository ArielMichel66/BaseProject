using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.UnitsOfWork.Interfaces;

public interface ICountriesUnitOfWork
{
    Task<ActionResponse<Country>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Country>>> GetAsync();

    ///paginado
    ///
    Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);
}