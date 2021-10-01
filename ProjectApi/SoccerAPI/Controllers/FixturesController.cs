using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SoccerAPI.Data;
using SoccerAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SoccerAPI.Controllers
{
	public class FixturesController : Controller
    {
        private readonly SoccerAPIContext _context;

        public FixturesController(SoccerAPIContext context)
        {
            _context = context;
        }

        // GET: Fixtures
        public IActionResult Index()
        {
            Api api = new Api();
            RestClient client = new RestClient(api.BaseAddress + "fixtures/date/2021-09-26?" + api.Key +
                "&include=localTeam,visitorTeam");
            client.Timeout = -1;
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JsonFixture[] responseFixtureArray = (JsonFixture[])JObject.Parse(response.Content)["data"].
                ToObject(typeof(JsonFixture[]));
            List<Fixture> fixtureList = new List<Fixture>();
            for (int i = 0; i < responseFixtureArray.Length; i++)
            {
                JsonFixture fixture = responseFixtureArray[i];
                var homeTeamData = fixture.localTeam["data"];
                var awayTeamData = fixture.visitorTeam["data"];
                var time = fixture.time["starting_at"]["date_time"];
                fixtureList.Add(
                new Fixture
                {
                    Id = (int)fixture.id,
                    HomeTeam = homeTeamData["name"].ToString(),
                    AwayTeam = awayTeamData["name"].ToString(),
                    HomeScore = Convert.ToInt32(fixture.scores["localteam_score"]),
                    AwayScore = Convert.ToInt32(fixture.scores["visitorteam_score"]),
                    FixtureDateTime = time.ToString()
                }
                );

            }
            

            ViewBag.Message = fixtureList;

            return View();
        }

        // GET: Fixtures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fixture fixture = await _context.Fixture
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fixture == null)
            {
                return NotFound();
            }

            return View(fixture);
        }

        // GET: Fixtures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fixtures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HomeTeam,AwayTeam,HomeScore,AwayScore,FixtureDateTime")] Fixture fixture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fixture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fixture);
        }

        // GET: Fixtures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixture = await _context.Fixture.FindAsync(id);
            if (fixture == null)
            {
                return NotFound();
            }
            return View(fixture);
        }

        // POST: Fixtures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HomeTeam,AwayTeam,HomeScore,AwayScore,FixtureDateTime")] Fixture fixture)
        {
            if (id != fixture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fixture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FixtureExists(fixture.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fixture);
        }

        // GET: Fixtures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixture = await _context.Fixture
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fixture == null)
            {
                return NotFound();
            }

            return View(fixture);
        }

        // POST: Fixtures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fixture = await _context.Fixture.FindAsync(id);
            _context.Fixture.Remove(fixture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FixtureExists(int id)
        {
            return _context.Fixture.Any(e => e.Id == id);
        }
        
        
    }
}
