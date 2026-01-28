using Microsoft.AspNetCore.Mvc;
using GestionaleApi.Models;
using GestionaleApi.Services;

namespace GestionaleApi.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomersController(ICustomerService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var customer = _service.GetById(id);
        if (customer == null)
            return NotFound();

        return Ok(customer);
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        _service.Add(customer);
        return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
    }
}
