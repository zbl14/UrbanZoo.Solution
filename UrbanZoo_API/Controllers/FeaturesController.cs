using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UrbanZoo.Models;
using UrbanZoo.Filter;
using UrbanZoo.Wrappers;
using UrbanZoo.Services;
using UrbanZoo.Helpers;

namespace UrbanZoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly UrbanZooContext _db;
        private readonly IUriService uriService;

        public FeaturesController(UrbanZooContext context, IUriService uriService)
        {
            this._db = context;
            this.uriService = uriService;
        }

        // GET: api/Features
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Feature>>> GetFeatures()
        // {
        //     return await _db.Features.ToListAsync();
        // }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feature>>> GetFeatures([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _db.Features
               .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
               .Take(validFilter.PageSize)
               .ToListAsync();
            var totalRecords = await _db.Features.CountAsync();
            // var response = await _db.Features.ToListAsync();
            var pagedResponse = PaginationHelper.CreatePagedReponse<Feature>(pagedData, validFilter, totalRecords, uriService, route);
            return Ok(pagedResponse);
        }

        // GET: api/Features/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Feature>> GetFeature(int id)
        // {
        //     var feature = await _db.Features.FindAsync(id);

        //     if (feature == null)
        //     {
        //         return NotFound();
        //     }

        //     return feature;
        // }

        [HttpGet("{id}")]
        public async Task<ActionResult<Feature>> GetFeature(int id)
        {
            var feature = await _db.Features.FindAsync(id);

            if (feature == null)
            {
                return NotFound();
            }

            return Ok(new Response<Feature>(feature));
        }

        // PUT: api/Features/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeature(int id, Feature feature)
        {
            if (id != feature.FeatureId)
            {
                return BadRequest();
            }

            _db.Entry(feature).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeatureExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return CreatedAtAction(nameof(GetFeature), new { id = feature.FeatureId }, feature);
        }


        // POST: api/Features
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Feature>> PostFeature([FromBody] Feature feature)
        {
            feature.CreatedDate = DateTime.Now;
            _db.Features.Add(feature);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetFeature", new { id = feature.FeatureId }, feature);
        }


        // DELETE: api/Features/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var feature = await _db.Features.FindAsync(id);
            if (feature == null)
            {
                return NotFound();
            }

            _db.Features.Remove(feature);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool FeatureExists(int id)
        {
            return _db.Features.Any(e => e.FeatureId == id);
        }
    }
}
