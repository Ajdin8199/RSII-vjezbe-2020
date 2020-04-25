﻿using AutoMapper;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseCRUDService<TModel, TSearch,TInsert, TUpdate, TDatabase> :
        BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {

        public BaseCRUDService(eProdajaContext context, IMapper mapper) : base(context,mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
             
            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int Id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(Id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
    }
}