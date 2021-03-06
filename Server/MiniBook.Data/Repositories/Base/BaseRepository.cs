﻿using MiniBook.Data.Context;

namespace MiniBook.Data.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected ResourceDbContext Context { get; }

        protected BaseRepository(ResourceDbContext context)
        {
            Context = context;
        }
    }
}
