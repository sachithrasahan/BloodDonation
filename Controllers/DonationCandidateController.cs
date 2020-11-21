using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationCandidateController : ControllerBase
    {
        private readonly DonationDBContext _context;
        public DonationCandidateController(DonationDBContext context)
        {
            _context = context;
        }

        // GET: api/DonationCandidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonationCandidate>>> GetCandidates()
        {
            return await _context.DonationCandidates.ToListAsync();
        }

        // GET: api/DonationCandidate/1
        [HttpGet("{id}")]
        public async Task<ActionResult<DonationCandidate>> GetCandidate(int id)
        {
            var candidate = await _context.DonationCandidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return candidate;
        }

        // POST: api/DonationCandidate
        [HttpPost]
        public async Task<ActionResult<DonationCandidate>> PostCandidate(DonationCandidate candidate)
        {
            _context.DonationCandidates.Add(candidate);
            await _context.SaveChangesAsync();
           
            return CreatedAtAction("GetCandidate", new {id = candidate.CandidateId}, candidate);
        }

        // DELETE: api/DonationCandidate/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<DonationCandidate>> DeleteCandidate(int id)
        {
            var candidate = await _context.DonationCandidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            _context.DonationCandidates.Remove(candidate);
            await _context.SaveChangesAsync();
            return candidate;
        }
    }
}
