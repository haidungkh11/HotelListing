﻿using HotelListing.Data;
using HotelListing.IRespository;
using HotelListing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace HotelListing.Respository
{
    public class GenericRespository<T> : IGenerticRespository<T> where T : class
    {
        private readonly DataBaseContext _context;
        private readonly DbSet<T> _db;
        public GenericRespository(DataBaseContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }
        public async Task Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            if (includes != null)
            {
                foreach (var includePropery in includes)
                {
                    query = query.Include(includePropery);
                }
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (includes != null)
            {
                foreach (var includePropery in includes)
                {
                    query = query.Include(includePropery);
                }
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.AsNoTracking().ToListAsync();
        }
        public async Task<X.PagedList.IPagedList<T>> GetPagedList(RequestParams requestParams, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _db;


            if (include != null)
            {
                query = include(query);
            }

            return await query.AsNoTracking()
                .ToPagedListAsync(requestParams.PageNumber, requestParams.PageSize);
        }
        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }


}
