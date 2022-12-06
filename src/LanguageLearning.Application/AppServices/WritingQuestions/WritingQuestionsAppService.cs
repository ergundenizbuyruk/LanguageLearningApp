using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.WritingQuestions.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.WritingQuestions
{
    [AbpAuthorize(PermissionNames.Admin)]
    public class WritingQuestionsAppService : ApplicationService
    {
        private readonly IRepository<WritingQuestion> _writingQuestions;

        public WritingQuestionsAppService(IRepository<WritingQuestion> writingQuestions)
        {
            _writingQuestions = writingQuestions;
        }

        [HttpPost]
        public async Task<WritingQuestionCreateOutputDto> Create(WritingQuestionCreateDto input)
        {
            WritingQuestion writingQuestion = new WritingQuestion
            {
                LessonId = input.LessonId,
                TurkishSentence = input.TurkishSentence,
                EnglishSentence = input.EnglishSentence,
            };

            var writingQuestionFromDb = await _writingQuestions.InsertAsync(writingQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new WritingQuestionCreateOutputDto
            {
                Id = writingQuestionFromDb.Id,
                LessonId = writingQuestionFromDb.LessonId,
                TurkishSentence = writingQuestionFromDb.TurkishSentence,
                EnglishSentence = writingQuestionFromDb.EnglishSentence,
            };
        }

        [HttpPut]
        public async Task<WritingQuestionCreateOutputDto> Update(WritingQuestionUpdateDto input)
        {
            WritingQuestion writingQuestion = await _writingQuestions.GetAsync(input.Id);
            writingQuestion.EnglishSentence = input.EnglishSentence;
            writingQuestion.TurkishSentence= input.TurkishSentence;

            var writingQuestionFromDb = await _writingQuestions.UpdateAsync(writingQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new WritingQuestionCreateOutputDto
            {
                Id = writingQuestionFromDb.Id,
                LessonId = writingQuestionFromDb.LessonId,
                TurkishSentence = writingQuestionFromDb.TurkishSentence,
                EnglishSentence = writingQuestionFromDb.EnglishSentence,

            };
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _writingQuestions.DeleteAsync(id);
        }
    }
}
