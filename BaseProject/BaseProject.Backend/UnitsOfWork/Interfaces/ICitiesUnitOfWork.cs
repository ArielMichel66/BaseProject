using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.UnitsOfWork.Interfaces;

public interface ICitiesUnitOfWork
{
    Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}