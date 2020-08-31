using PoorManReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoorManReddit.Services
{
    public interface IRedditService
    {
        Task<IEnumerable<Child>> GetAll();
    }
}
