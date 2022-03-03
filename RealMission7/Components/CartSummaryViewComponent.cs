﻿using Microsoft.AspNetCore.Mvc;
using RealMission7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Components
{
    public class CartSummaryViewComponent : ViewComponent 
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
