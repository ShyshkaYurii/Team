using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoftServeITAcademyProject.Data;
using SoftServeITAcademyProject.Data.Entities;

namespace SoftServeITAcademyProject
{
    public class IndexModel : PageModel
    {
        private readonly SoftServeITAcademyProject.Data.ApplicationDbContext _context;

        public IndexModel(SoftServeITAcademyProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Player> FirstTeamPlayers { get;set; }

        public IList<Player> SecondTeamPlayers { get;set; }
        public IList<Player> Trainers { get; set; }

        public async Task OnGetAsync()
        {
            FirstTeamPlayers = await _context.Players
                .Where(x => x.Position == PlayerPosition.FirstTeamPlayer
                            || x.Position == PlayerPosition.Trainer)
                .ToListAsync();

            SecondTeamPlayers = await _context.Players
                .Where(x => x.Position == PlayerPosition.SecondTeamPlayer)
                .ToListAsync();

            Trainers = await _context.Players
                .Where(x => x.Position == PlayerPosition.Trainer)
                .ToListAsync();
        }
    }
}
