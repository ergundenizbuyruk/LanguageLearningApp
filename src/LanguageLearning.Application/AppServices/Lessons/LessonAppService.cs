﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Lessons.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Lessons
{
    public class LessonAppService : AsyncCrudAppService<Lesson, LessonDto, int, LessonDto, LessonCreateDto, LessonUpdateDto>, ILessonAppService
    {
        public LessonAppService(IRepository<Lesson, int> repository) : base(repository)
        {
        }

        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
    }


    public interface ILessonAppService : IAsyncCrudAppService<LessonDto, int, LessonDto, LessonCreateDto, LessonUpdateDto> { }
}
