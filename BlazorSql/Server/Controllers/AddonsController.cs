// ======================================
//  Blazor Spread. LHTV
// ======================================
using BlazorSql.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using BlazorSql.Shared;
using IO = System.IO;

namespace BlazorSql.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddonsController : ControllerBase
    {
        readonly SqlContext _context;
        readonly string _path;

        public AddonsController(IWebHostEnvironment env, SqlContext context)
        {
            _path = env.ContentRootPath;
            _context = context;
        }

        [HttpGet("BooksSample")]
        public async Task<List<Book>> BooksSample()
        {
            if (await _context.Books.AnyAsync()) {
                return null;
            }
            var file = $"{_path}/Statics/books_sample.json";

            var data = JsonSerializer.Deserialize<List<Book>>(
                IO.File.ReadAllText(file),
                new JsonSerializerOptions { 
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase 
                });
            // add to database
            _context.Books.AddRange(data);
            await _context.SaveChangesAsync();
            return data;
        }

    }
}
