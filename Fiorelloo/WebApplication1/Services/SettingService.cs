﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;

namespace WebApplication1.Services
{
    public class SettingService
    {
        public AppDbContext _context { get; }
        public SettingService(AppDbContext context)
        {
            _context = context;
        }
        public Dictionary<string,string> GetAllSettings()
        {
            return _context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
    }
}
