using UrbanZoo.Filter;
using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace UrbanZoo.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}