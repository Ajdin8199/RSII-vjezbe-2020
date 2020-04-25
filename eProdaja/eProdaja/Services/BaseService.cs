﻿using AutoMapper;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        protected eProdajaContext _context;
        protected IMapper _mapper;
        public BaseService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int Id)
        {
            var entity = _context.Set<TDatabase>().Find(Id);

            return _mapper.Map<TModel>(entity);
        }
    }
}