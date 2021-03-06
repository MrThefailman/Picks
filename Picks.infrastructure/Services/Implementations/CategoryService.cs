﻿using AutoMapper;
using Picks.core.Entities;
using Picks.infrastructure.Repositories.Interfaces;
using Picks.infrastructure.Services.Interfaces;
using Picks.infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Picks.infrastructure.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        public readonly ICategoryService _categoryRepo;
        public readonly IMapper _mapper;
        public CategoryService(
            ICategoryService categoryRepo,
            IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task Add(Category vm)
        {
            await _categoryRepo.Add(_mapper.Map<Category>(vm));
        }

        public async Task<IEnumerable<CategoryViewModel>> Get()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(await _categoryRepo.Get());
        }
    }
}
