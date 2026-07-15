using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.Repositories.Interfaces;

public interface IStatesRepository
{
    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<State>>> GetAsync();

    ///paginado
    ///
    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}