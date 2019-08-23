using System;
using System.Linq;
using System.Collections.Generic;
using WebApplicationMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationMVC.Services
{
    public class DepartmentService
    {
        private readonly WebApplicationMVCContext _context;

        public DepartmentService(WebApplicationMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
