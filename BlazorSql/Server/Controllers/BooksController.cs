// ======================================
//  Blazor Spread. LHTV
// ======================================
using BlazorSql.Server.Services;
using BlazorSql.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSql.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : DataHandlerController<Book>
    {
        public BooksController(IDataService<Book> service) : base(service) { }
    }
}

