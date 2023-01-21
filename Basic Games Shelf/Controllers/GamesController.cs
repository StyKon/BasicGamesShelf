using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Basic_Games_Shelf.Data;
using Basic_Games_Shelf.Models;
using Basic_Games_Shelf.IServices;

namespace Basic_Games_Shelf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        private readonly IGamesService _gamesService;

        public GamesController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Games>>> GetGames()
        {
            return Ok(await _gamesService.GetGames());
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Games>> GetGames(int id)
        {
            return Ok(await _gamesService.GetGames(id));
        }

        // PUT: api/Games/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGames(int id, Games games)
        {
            return Ok(await _gamesService.PutGames(id, games));
        }

        // POST: api/Games
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Games>> PostGames([FromBody] Games games)
        {
            return Ok(await _gamesService.PostGames(games));
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGames(int id)
        {
            return Ok(await _gamesService.DeleteGames(id));
        }

        private bool GamesExists(int id)
        {
            return _gamesService.GamesExists(id);
        }
    }
}
