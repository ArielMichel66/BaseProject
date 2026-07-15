using BaseProject.Backend.Repositories.Interfaces;
using BaseProject.Backend.UnitsOfWork.Interfaces;
using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;

namespace BaseProject.Backend.UnitsOfWork.Implementations;

public class StatesUnitOfWork : GenericUnitOfWork<State>, IStatesUnitOfWork
{
    private readonly IStatesRepository _statesRepository;

    public StatesUnitOfWork(IGenericRepository<State> repository, IStatesRepository statesRepository) : base(repository)
    {
        _statesRepository = statesRepository;
    }

    public override async Task<ActionResponse<IEnumerable<State>>> GetAsync() => await _statesRepository.GetAsync();

    public override async Task<ActionResponse<State>> GetAsync(int id) => await _statesRepository.GetAsync(id);

    ///paginado
    ///
    public override async Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination) => await _statesRepository.GetAsync(pagination);

    public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _statesRepository.GetTotalRecordsAsync(pagination);
}