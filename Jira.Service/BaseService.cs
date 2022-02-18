using ApiJira.Dto;
using ApiJira.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Services
{
    public class BaseService<T, TDto> : ControllerBase, IBaseService<T, TDto> where T : BaseEntity where TDto : BaseDto
    {
        protected readonly IApplicationDbContext _context;
        protected readonly IMapper _mapper;
        protected readonly DbSet<T> _dbset;


        public BaseService(IApplicationDbContext context, IMapper mapper)
        {
            _dbset = context.GetDbSet<T>();
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<T>> Get()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TDto> Get(int id)
        {
            var entity = await _dbset.FindAsync(id);

            if (entity == null)
            {
                return null;
            }

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }
        public virtual async Task<TDto> Create(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);

            _dbset.Add(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }

        public virtual async Task<TDto> Edit(int id, TDto dto)
        {
            var entity = await _dbset.FindAsync(id);

            if (entity == null)
            {
                return null;
            }

            entity = _mapper.Map(dto, entity);

            _dbset.Update(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _dbset.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _dbset.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }

}
