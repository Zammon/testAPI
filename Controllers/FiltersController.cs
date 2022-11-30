using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.ApplicationDbContext;
using TestAPI.Dto;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private readonly SqlServerDbContext _db;

        public FiltersController(SqlServerDbContext db)
        {
            _db = db;
        }

        [HttpGet("Find/[action]/{nametype}")]
        public async Task<FilterItemDto> FindType(string nametype)
        {
            Filter title = await _db.Filters.Where( data => data.NameFilter == nametype).FirstOrDefaultAsync();
            var items = await _db.ItemsFilters.Where(data => data.IdFilter == title.IdFilter).Select(item => item.NameItemFiter).ToListAsync();
            FilterItemDto filterItem = new FilterItemDto()
            {
                IdFilter = title.IdFilter,
                NameFilter = title.NameFilter,
                NameItemFilter = items
            };

            return filterItem;
        }

        //[HttpGet("filter/[action]/{typename}")]
        //public async Task<ActionResult<FilterItemDto>> Typepost(string typename) 
        //{ 
        //    Filter gFilter = await _db.Filters.Where(filter => filter.Titlename == typename).FirstOrDefaultAsync();
        //    var test = await _db.FilterItems.Where(i => i.IdFilter == gFilter.IdFilter).Select(a => a.Itemname).ToListAsync();

        //    FilterItemDto FilterItems = new FilterItemDto()
        //    {
        //        IdFilter = gFilter.IdFilter,
        //        Tiltename = gFilter.Titlename,
        //        Items = test
        //    };

        //    return Ok(FilterItems);
        //}

        //    [HttpGet("filter/[action]")] 
        //    public async Task<List<Tag>> Tags()
        //    {
        //        return await _db.Tags.ToListAsync();;
        //    }

    }
}
