﻿using Abp.Domain.Repositories;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlog.Repositories
{
    public interface IBlogRepository : IRepository<Blog, Guid>
    {
    }
}
