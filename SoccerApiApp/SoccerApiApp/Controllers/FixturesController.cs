using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoccerApiApp.Data;
using SoccerApiApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace SoccerApiApp.Controllers
{
	public class FixturesController : Controller
    {
        private readonly SoccerApiAppContext _context;

        public FixturesController(SoccerApiAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["HomeSortParm"] = sortOrder == "hometeam_desc" ? "hometeam_asc" : "hometeam_desc";
            ViewData["AwaySortParm"] = sortOrder == "awayteam_desc" ? "awayteam_asc" : "awayteam_desc";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
			IQueryable<Fixture> fixture = from f in _context.Fixture
                                          select f;
            switch (sortOrder)
            {
                case "hometeam_desc":
                    fixture = fixture.OrderByDescending(f => f.HomeTeam);
                    break;
                case "hometeam_asc":
                    fixture = fixture.OrderBy(f => f.HomeTeam);
                    break;
                case "awayteam_desc":
                    fixture = fixture.OrderByDescending(f => f.AwayTeam);
                    break;
                case "awayteam_asc":
                    fixture = fixture.OrderBy(f => f.AwayTeam);
                    break;
                case "Date":
                    fixture = fixture.OrderBy(f => f.FixtureDateTime);
                    break;
                case "date_asc":
                    fixture = fixture.OrderBy(f => f.FixtureDateTime);
                    break;
                default:
                    fixture = fixture.OrderByDescending(f => f.FixtureDateTime);
                    break;
            }
            return View(await fixture.AsNoTracking().ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(int week)
		{
            List<Fixture> blogs = new List<Fixture>();

            switch (week)
			{
                case 3:
                    blogs = await Task.Run(() => _context.Fixture
                        .FromSqlRaw(@"SELECT *
                                FROM dbo.Fixture
                                WHERE
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) >= 
                                        (SELECT GETDATE()-28) AND
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) <= 
                                        (SELECT GETDATE()-21)")
                        .ToList());
                    break;
                case 2:
                    blogs = await Task.Run(() => _context.Fixture
                        .FromSqlRaw(@"SELECT *
                                FROM dbo.Fixture
                                WHERE
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) >= 
                                        (SELECT GETDATE()-21) AND
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) <= 
                                        (SELECT GETDATE()-14)")
                        .ToList());
                    break;
                case 1:
                    blogs = await Task.Run(() => _context.Fixture
                        .FromSqlRaw(@"SELECT *
                                FROM dbo.Fixture
                                WHERE
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) >= 
                                        (SELECT GETDATE()-14) AND
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) <= 
                                        (SELECT GETDATE()-7)")
                        .ToList());
                    break;
                case 0:
                    blogs = await Task.Run(() => _context.Fixture
                        .FromSqlRaw(@"SELECT *
                                FROM dbo.Fixture
                                WHERE
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) >= 
                                        (SELECT GETDATE()-7) AND
                                    (SELECT TRY_CONVERT(datetime, dbo.Fixture.FixtureDateTime,102)) <= 
                                        (SELECT GETDATE())")
                        .ToList());
                    break;
                default:
                    return RedirectToAction("Index");
            }
			 
            
            
            return View(blogs);
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

		//Get fixtures from API, save to db and return a view with all db
		public async Task<ActionResult> GetFixtures()
        {
            List<Fixture> fixtures = JsonFixture.AddJsonFixtures();
			foreach (Fixture fi in fixtures)
			{
                if (ModelState.IsValid)
                {
                    if (!FixtureExists(fi.Id))
                    {
                        _context.Add(fi);
                    }
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", await _context.Fixture.ToListAsync());
        }

		private bool FixtureExists(int id)
        {
            return _context.Fixture.Any(e => e.Id == id);
        }
    }
}
