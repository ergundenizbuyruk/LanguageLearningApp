using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Comments.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Comments
{
    [AbpAuthorize]
    public class CommentAppService : ApplicationService
    {

        private readonly IRepository<Comment> _commentRepository;

        public CommentAppService(IRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CommentDto>> GetAsync(int id)
        {
            var comment = await _commentRepository.GetAsync(id);

            if (comment == null)
            {
                return new NotFoundResult();
            }

            return new CommentDto
            {
                Content = comment.Content,
                Rate = comment.Rate,
                Id = comment.Id,
                UserId = comment.UserId,
                LessonId = comment.LessonId,
            };
        }

        [HttpGet]
        public async Task<ActionResult<List<CommentByLessonDto>>> GetAllByLessonAsync(int lessonId)
        {
            var comment = await _commentRepository.GetAll().Where(p => p.LessonId == lessonId).Include(p => p.User).ToListAsync();

            if (comment == null)
            {
                return new NotFoundResult();
            }

            return ObjectMapper.Map<List<CommentByLessonDto>>(comment);
        }
        [HttpGet]
        public async Task<List<CommentDto>> GetAllAsync()
        {
            return _commentRepository.GetAllListAsync().Result.Select(u => new CommentDto
            {
                Content = u.Content,
                Rate = u.Rate,
                Id = u.Id,
                UserId = u.UserId,
                LessonId = u.LessonId,
            }).ToList();

        }

        [HttpPost]
        [AbpAuthorize(PermissionNames.Student)]
        public async Task<CommentCreateOutputDto> CreateAsync(CommentCreateDto input)
        {
            Comment comment = new Comment
            {
                LessonId = input.LessonId,
                Content = input.Content,
                Rate = input.Rate,
                UserId = (long) AbpSession.UserId
            };

            var commentFromDb = await _commentRepository.InsertAsync(comment);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new CommentCreateOutputDto
            {
                Id = commentFromDb.Id,
                LessonId = commentFromDb.LessonId,
                Content = commentFromDb.Content,
                Rate = commentFromDb.Rate,
            };

        }
        [HttpPut]
        [AbpAuthorize(PermissionNames.Student)]
        public async Task<ActionResult<CommentCreateOutputDto>> UpdateAsync(CommentUpdateDto input)
        {
            var comment = await _commentRepository.GetAsync(input.Id);

            if(comment == null)
            {
                return new NotFoundResult();
            }

            comment.Content = input.Content;
            comment.Rate = input.Rate;

            var commentFromDb = await _commentRepository.UpdateAsync(comment);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new CommentCreateOutputDto
            {
                Id = commentFromDb.Id,
                LessonId = commentFromDb.LessonId,
                Content = commentFromDb.Content,
                Rate = commentFromDb.Rate
            };

        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _commentRepository.DeleteAsync(id);
        }
    }
}
