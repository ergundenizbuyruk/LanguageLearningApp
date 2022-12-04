using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.SpeakingQuestions.Dtos;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.SpeakingQuestions
{
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
                LessonId = speakingQuestionFromDb.LessonId,
                EnglishSentence= speakingQuestionFromDb.EnglishSentence
            };
        }

        [HttpPatch]
        public async Task<SpeakingQuestionCreateOutputDto> Update(SpeakingQuestionUpdateDto input)
        {
            SpeakingQuestion speakingQuestion = new SpeakingQuestion
            {
                LessonId = input.LessonId,
                EnglishSentence=input.EnglishSentence,
            };

            var speakingQuestionFromDb = await _speakingQuestions.UpdateAsync(speakingQuestion);
            return new SpeakingQuestionCreateOutputDto
            {
                
                LessonId = speakingQuestionFromDb.LessonId,
                EnglishSentence=speakingQuestionFromDb.EnglishSentence
                
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
