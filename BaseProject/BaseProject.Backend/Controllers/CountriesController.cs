using BaseProject.Backend.UnitsOfWork.Interfaces;
using BaseProject.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : GenericController<Country>
{
    public CountriesController(IGenericUnitOfWork<Country> unit) : base(unit)
    {
    }
}