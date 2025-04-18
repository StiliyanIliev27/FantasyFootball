﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyFootball.Infrastructure.Data;

namespace FantasyFootball.Infrastructure.Common
{
    public class Repository : IRepository
    {
        private readonly FantasyFootballDbContext context;

        public Repository(FantasyFootballDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        private DbSet<T> DbSet<T>() where T : class => context.Set<T>();

        public IQueryable<T> All<T>() where T : class => DbSet<T>();

        public IQueryable<T> AllReadOnly<T>() where T : class => DbSet<T>().AsNoTracking();

        public async Task AddAsync<T>(T entity) where T : class => await context.AddAsync(entity);

        public EntityEntry Delete<T>(T entity) where T : class => context.Remove(entity);

        public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            context.Update(entity);
            await Task.CompletedTask;
        }
        public async Task<T?> GetByIdAsync<T>(object id) where T : class => await DbSet<T>().FindAsync(id);
    }
}
