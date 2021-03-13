// ======================================
//  Blazor Spread. LHTV
// ======================================
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSql.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSql.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataHandlerController<T> : ControllerBase where T : class
    {
        readonly IDataService<T> _service;

        public DataHandlerController(IDataService<T> service)
        {
            _service = service;
        }

        // GET: api/T
        [HttpGet]
        public async Task<IEnumerable<T>> Get()
        {
            return await _service.Items();
        }

        // GET: api/T/5
        [HttpGet("{id}")]
        public async Task<T> Get(int id)
        {
            return await _service.Read(id);
        }

        // PUT: api/T
        [HttpPut]
        public async Task<bool> Put(T item)
        {
            return await _service.Update(item);
        }

        // POST: api/T
        [HttpPost]
        public async Task<bool> Post(T item)
        {
            return await _service.Create(item);
        }

        // DELETE: api/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}
