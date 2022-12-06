using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.SpeakingQuestions.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.SpeakingQuestions
{
    [AbpAuthorize(PermissionNames.Admin)]
    public class SpeakingQuestionsAppService : ISpeakingQuestionsAppService
    {
        private readonly IRepository<SpeakingQuestion> _speakingQuestions;

        public SpeakingQuestionsAppService(IRepository<SpeakingQuestion> speakingQuestions)
        {
            _speakingQuestions = speakingQuestions;
        }

        [HttpPost]
        public async Task<SpeakingQuestionCreateOutputDto> Create(SpeakingQuestionCreateDto input)
        {
            SpeakingQuestion speakingQuestion = new SpeakingQuestion
            {
                LessonId = input.LessonId,
                EnglishSentence = input.EnglishSentence,
            };

            var speakingQuestionFromDb = await _speakingQuestions.InsertAsync(speakingQuestion);
            return new SpeakingQuestionCreateOutputDto
            {
                Id = speakingQuestion.Id,
                LessonId = speakingQuestionFromDb.LessonId,
                EnglishSentence = speakingQuestionFromDb.EnglishSentence
            };
        }

        [HttpPut]
        public async Task<SpeakingQuestionCreateOutputDto> Update(SpeakingQuestionUpdateDto input)
        {
            SpeakingQuestion speakingQuestion = new SpeakingQuestion
            {
                Id = input.Id,
                LessonId = input.LessonId,
                EnglishSentence = input.EnglishSentence,
            };

            var speakingQuestionFromDb = await _speakingQuestions.UpdateAsync(speakingQuestion);
            return new SpeakingQuestionCreateOutputDto
            {
                Id = speakingQuestionFromDb.Id,
                LessonId = speakingQuestionFromDb.LessonId,
                EnglishSentence = speakingQuestionFromDb.EnglishSentence

            };
        }

        [HttpDelete]
        public async Task Delete(int input)
        {
            await _speakingQuestions.DeleteAsync(input);
        }

    }
    public interface ISpeakingQuestionsAppService : IApplicationService { }
}
