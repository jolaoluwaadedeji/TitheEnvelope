using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TitheEnvelope.DAL.Models;
using TitheEnvelopeApi.Models;
using TitheEnvelopeApi.Models.DTO;
using TitheEnvelopeApi.Models.DTO.Interface;

namespace TitheEnvelope.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitherDetailController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public TitherDetailController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //GET: api/TitherDetail
       [HttpGet]
        public IEnumerable<TitherDetail> GetTitherDetails()
        {
            return _unitOfWork.TitherDetailRepository.GetAll();
        }

       // GET: api/TitherDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTitheObject([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var titheObject = await _context.TitherDetail.FindAsync(id);

            if (titheObject == null)
            {
                return NotFound();
            }

            return Ok(titheObject);
        }

       // PUT: api/TitherDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTitheObject([FromRoute] long id, [FromBody] TitherDetail titherDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != titherDetail.TitherDetailId)
            {
                return BadRequest();
            }

            _context.Entry(titherDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitheObjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

       // POST: api/TitherDetail
       [HttpPost]
        public async Task<IActionResult> PostTitherDetail([FromBody] TitherDetail titherDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TitherDetail.Add(titherDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTitheObject", new { id = titherDetail.TitherDetailId }, titherDetail);
        }

       // DELETE: api/TitherDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTitheObject([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var titheObject = await _context.TitherDetail.FindAsync(id);
            if (titheObject == null)
            {
                return NotFound();
            }

            _context.TitherDetail.Remove(titheObject);
            await _context.SaveChangesAsync();

            return Ok(titheObject);
        }

        private bool TitheObjectExists(long id)
        {
            return _context.TitherDetail.Any(e => e.TitherDetailId == id);
        }
    }
}