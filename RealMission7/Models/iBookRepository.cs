using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Models
{
    public interface iBookRepository
    {
        IQueryable<Books> Books { get; }
    }
}
