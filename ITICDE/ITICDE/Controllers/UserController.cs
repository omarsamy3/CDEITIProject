using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITICDE.Data;
using ITICDE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis;


namespace ITICDE.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly CDEDBContext _context;

        public UserController(CDEDBContext context)
        {
            _context = context;
        }
        #region Index
        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
        #endregion

        #region ProjectUsers
        public IActionResult ProjectUsers(int ProjectId)
        {
            ITICDE.Models.Project project = _context.Projects.Include(u => u.Users).FirstOrDefault(w => w.Id == ProjectId);
            var projectuser = _context.Users.Include(i => i.WorkonProjects).ToList();
            ViewBag.project = project;
            return View(projectuser);
        }
        #endregion

        #region AddTeamUser
        public async Task<IActionResult> AddTeamUser(int? TeamId, int ProjectId)
        {
            var project = await _context.Projects.Include(c => c.Users).Where(c => c.Id == ProjectId).FirstOrDefaultAsync();

            var team = _context.Teams.Include(t => t.Users).FirstOrDefault(i => i.Id == TeamId);

            ViewBag.RequiredTeam = team;
            ViewBag.project = project;
            return View(project.Users);

        }

        //POST: Team User
        public IActionResult AddToTeam(int? TeamId, string UserId, int ProjectId)
        {

            var team = _context.Teams.Include(t => t.Users).FirstOrDefault(t => t.Id == TeamId);
            var user = _context.Users.FirstOrDefault(u => u.Id == UserId);
            team.Users.Add(user);
            _context.SaveChanges();
            ViewBag.RequiredTeam = team;
            return RedirectToAction(nameof(AddTeamUser), new { ProjectId, TeamId });
        }
        #endregion


        #region Details
        // GET: User/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        #endregion


        #region Create
        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,ConfirmEmail,Password,Role,OrganizationType,Discipline")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        #endregion


        #region Edit
        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }



        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Email,ConfirmEmail,Password,Role,OrganizationType,Discipline")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }
        #endregion


        #region Delete
        // GET: User/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region UserExists
        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        #endregion

        #region DeleteTeamUser
        //GET: TeamUser with its team and project id.
        public async Task<IActionResult> DeleteTeamUser(string UserId, int TeamId, int ProjectId)
        {
            if (UserId == null || TeamId == 0)
            {
                return NotFound();
            }
            var team = _context.Teams.Include(c => c.Users).FirstOrDefault(t => t.Id == TeamId);
            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == UserId);
            ViewBag.RequiredTeam = team;
            ViewBag.ProjectId = ProjectId;
            if (user == null || team == null)
            {
                return NotFound();
            }


            return View(user);
        }

        // POST: Team/Delete/5
        [HttpPost, ActionName("DeleteTeamUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserConfirmed(string id, int TeamId, int ProjectId)
        {
            var team = _context.Teams.Include(c => c.Users).FirstOrDefault(t => t.Id == TeamId);
            var user = await _context.Users.FindAsync(id);
            team.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("UsersDetails", "Team", new { ProjectId = ProjectId, id = TeamId });
        }
        #endregion


    }
}
