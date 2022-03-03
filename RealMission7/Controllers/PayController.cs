using Microsoft.AspNetCore.Mvc;
using RealMission7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Controllers
{
    public class PayController : Controller
    {
        private IPayRepository repo { get; set; }
        private Cart cart { get; set; }

        public PayController (IPayRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Pay());
        }

        [HttpPost]
        public IActionResult Checkout(Pay payment)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                payment.Lines = cart.Items.ToArray();
                repo.SavePayment(payment);
                cart.ClearCart();

                return RedirectToPage("/CheckoutCompleted");
            }

            else
            {
                return View();
            }
        }
    }
}
