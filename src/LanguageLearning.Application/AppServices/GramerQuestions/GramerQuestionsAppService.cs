using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.GramerQuestions.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.GramerQuestions
{
    [AbpAuthorize(PermissionNames.Admin)]
    public class GramerQuestionsAppService : IGramerQuestionsAppService
    {
        private readonly IRepository<GramerQuestion> _gramerQuestions;

        public GramerQuestionsAppService(IRepository<GramerQuestion> gramerQuestions)
        {
            _gramerQuestions = gramerQuestions;
        }

        [HttpPost]
        public async Task<GramerQuestionCreateOutputDto> Create(GramerQuestionCreateDto input)
        {
            GramerQuestion gramerQuestion = new GramerQuestion
            {
                LessonId = input.LessonId,
                Sentence = input.Sentence,
                OptionA = input.OptionA,
                OptionB = input.OptionB,
                OptionC = input.OptionC,
                OptionD = input.OptionD,
                CorrectOption = input.CorrectOption
            };

            var gramerQuestionFromDb = await _gramerQuestions.InsertAsync(gramerQuestion);
            return new GramerQuestionCreateOutputDto
            {
                Id = gramerQuestion.Id,
                LessonId = gramerQuestionFromDb.LessonId,
                Sentence = gramerQuestionFromDb.Sentence,
                OptionA = gramerQuestionFromDb.OptionA,
                OptionB = gramerQuestionFromDb.OptionB,
                OptionC = gramerQuestionFromDb.OptionC,
                OptionD = gramerQuestionFromDb.OptionD,
                CorrectOption = gramerQuestionFromDb.CorrectOption
            };
        }

        [HttpPatch]
        public async Task<GramerQuestionCreateOutputDto> Update(GramerQuestionUpdateDto input)
        {
            GramerQuestion gramerQuestion = new GramerQuestion
            {
                Id = input.Id,
                LessonId = input.LessonId,
                Sentence = input.Sentence,
                OptionA = input.OptionA,
                OptionB = input.OptionB,
                OptionC = input.OptionC,
                OptionD = input.OptionD,
                CorrectOption = input.CorrectOption
            };

            var gramerQuestionFromDb = await _gramerQuestions.UpdateAsync(gramerQuestion);
            return new GramerQuestionCreateOutputDto
            {
                Id = gramerQuestion.Id,
                LessonId = gramerQuestionFromDb.LessonId,
                Sentence = gramerQuestionFromDb.Sentence,
                OptionA = gramerQuestionFromDb.OptionA,
                OptionB = gramerQuestionFromDb.OptionB,
                OptionC = gramerQuestionFromDb.OptionC,
                OptionD = gramerQuestionFromDb.OptionD,
                CorrectOption = gramerQuestionFromDb.CorrectOption
            };
        }

        [HttpDelete]
        public async Task Delete(int input)
        {
            await _gramerQuestions.DeleteAsync(input);
        }

    }

    public interface IGramerQuestionsAppService : IApplicationService { }
}
