﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskNest.DAL;
using TaskNest.ViewModels;

namespace TaskNest.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;

        public LayoutServices(AppDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(p => p.Key, p => p.Value);
        }
        public int GetBasketItemCount()
        {
            if (_accessor.HttpContext.Request.Cookies["Basket"] == null)
            {
                return 0;
            }
            ICollection<BasketVM> basket = JsonConvert.DeserializeObject<ICollection<BasketVM>>(_accessor.HttpContext.Request.Cookies["Basket"]);
            return basket.Sum(b => b.Count);
        }
    }
}
