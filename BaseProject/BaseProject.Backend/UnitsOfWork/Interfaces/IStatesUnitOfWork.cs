using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.UnitsOfWork.Interfaces;

public interface IStatesUnitOfWork
{
    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<State>>> GetAsync();

    ///paginado
    ///
    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}