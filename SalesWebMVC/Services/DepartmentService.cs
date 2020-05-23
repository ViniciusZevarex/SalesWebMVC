using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _contex;

        public DepartmentService(SalesWebMVCContext context)
        {
            _contex = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _contex.Department.OrderBy(x => x.Name).ToListAsync();
        }


    }
}
