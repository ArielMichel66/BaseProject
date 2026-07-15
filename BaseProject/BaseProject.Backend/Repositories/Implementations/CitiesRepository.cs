using BaseProject.Backend.Data;
using BaseProject.Backend.Helpers;
using BaseProject.Backend.Repositories.Interfaces;
using BaseProject.Shared.DTOs;
using BaseProject.Shared.Entities;
using BaseProject.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Backend.Repositories.Implementations;

public class CitiesRepository : GenericRepository<City>, ICitiesRepository
{
    private readonly DataContext _context;

    public CitiesRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination)
    {
        var queryable = _context.Cities
            .Where(x => x.State!.Id == pagination.Id)
            .AsQueryable();

        return new ActionResponse<IEnumerable<City>>
        {
            WasSuccess = true,
            Result = await queryable
                .OrderBy(x => x.Name)
                .Paginate(pagination)
                .ToListAsync()
        };
    }

    public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination)
    {
        var queryable = _context.Cities
            .Where(x => x.State!.Id == pagination.Id)
            .AsQueryable();

        double count = await queryable.CountAsync();
        return new ActionResponse<int>
        {
            WasSuccess = true,
            Result = (int)count
        };
    }
}