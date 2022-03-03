using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Models
{
    public class EFPayRepository : IPayRepository
    {
        private BookstoreContext context;

        public EFPayRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Pay> Payment => context.Payment.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePayment(Pay payment)
        {
            context.AttachRange(payment.Lines.Select(x => x.Book));

            if (payment.PaymentId == 0)
            {
                context.Payment.Add(payment);
            }

            context.SaveChanges();
        }
            
    }
}
