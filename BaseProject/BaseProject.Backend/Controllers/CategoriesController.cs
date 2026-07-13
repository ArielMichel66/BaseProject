using BaseProject.Backend.UnitsOfWork.Interfaces;
using BaseProject.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : GenericController<Category>
{
    public CategoriesController(IGenericUnitOfWork<Category> unit) : base(unit)
    {
    }
}