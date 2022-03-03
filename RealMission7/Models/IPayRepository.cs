using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Models
{
    public interface IPayRepository
    {
        public IQueryable<Pay> Payment { get; }

        public void SavePayment(Pay payment);
    }
}
