using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.WritingQuestions.Dtos;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.WritingQuestions
{
    public class WritingQuestionsAppService : IWritingQuestionsAppService
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
            return new WritingQuestionCreateOutputDto
            {
                
                LessonId = writingQuestionFromDb.LessonId,
                TurkishSentence=writingQuestionFromDb.TurkishSentence,
                EnglishSentence=writingQuestionFromDb.EnglishSentence,
                
            };
        }

        [HttpPatch]
        public async Task<WritingQuestionCreateOutputDto> Update(WritingQuestionUpdateDto input)
        {
            WritingQuestion writingQuestion = new WritingQuestion
            {
                LessonId = input.LessonId,
                TurkishSentence = input.TurkishSentence,
                EnglishSentence = input.EnglishSentence,
            };

            var writingQuestionFromDb = await _writingQuestions.UpdateAsync(writingQuestion);
            return new WritingQuestionCreateOutputDto
            {

                LessonId = writingQuestionFromDb.LessonId,
                TurkishSentence = writingQuestionFromDb.TurkishSentence,
                EnglishSentence = writingQuestionFromDb.EnglishSentence,

            };
        }

        [HttpDelete]
        public async Task Delete(int input)
        {
            await _writingQuestions.DeleteAsync(input);
        }
    }
    public interface IWritingQuestionsAppService : IApplicationService { }
}
