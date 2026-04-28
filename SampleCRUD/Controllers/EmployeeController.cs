using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCRUD.Entities;
using SampleCRUD.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext context;

        public EmployeeController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult> Get()

           => Ok(await context.Employees.ToListAsync());
        [HttpPost]
        public async Task<ActionResult> Create(Employee employee)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();
            return Ok(employee);
        }
        [HttpPut]
        public async Task<ActionResult> Update(Employee employee)
        {
            context.Employees.Update(employee);
            await context.SaveChangesAsync();
            return Ok(employee);
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var employee = await context.Employees.FindAsync(id);
            if (employee == null) return NotFound();
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
