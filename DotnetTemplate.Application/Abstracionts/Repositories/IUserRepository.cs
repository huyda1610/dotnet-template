﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Application.Abstracionts.Repositories
{
    public interface IUserRepository
    {
        Task GetAllAsync(Guid guid);
    }
}
