﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly SoftServeITAcademyProject.Data.ApplicationDbContext _context;

        public DetailsModel(SoftServeITAcademyProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players.FirstOrDefaultAsync(m => m.Id == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
