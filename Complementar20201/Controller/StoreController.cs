using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Complementar20201.Models;
using Microsoft.AspNetCore.Mvc;

namespace Complementar20201.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly complementar20201Context _db;
        public StoreController(complementar20201Context db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Stores>>> Get()
        {
            return await _db.Stores.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Stores store)
        {
            _db.Add(store);
            await _db.SaveChangesAsync();
            return Ok(store.StoreId);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var store = await _db.Stores.FirstOrDefaultAsync(x => x.StoreId == id);
            _db.Remove(store);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}