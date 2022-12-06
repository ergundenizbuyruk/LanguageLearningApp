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
    public class GramerQuestionsAppService : ApplicationService
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
            await CurrentUnitOfWork.SaveChangesAsync();
            
            return new GramerQuestionCreateOutputDto
            {
                Id = gramerQuestionFromDb.Id,
                LessonId = gramerQuestionFromDb.LessonId,
                Sentence = gramerQuestionFromDb.Sentence,
                OptionA = gramerQuestionFromDb.OptionA,
                OptionB = gramerQuestionFromDb.OptionB,
                OptionC = gramerQuestionFromDb.OptionC,
                OptionD = gramerQuestionFromDb.OptionD,
                CorrectOption = gramerQuestionFromDb.CorrectOption
            };
        }

        [HttpPut]
        public async Task<GramerQuestionCreateOutputDto> Update(GramerQuestionUpdateDto input)
        {
            var gramerQuestion = await _gramerQuestions.GetAsync(input.Id);
            gramerQuestion.Sentence= input.Sentence;
            gramerQuestion.OptionA= input.OptionA;
            gramerQuestion.OptionB= input.OptionB;
            gramerQuestion.OptionC= input.OptionC;
            gramerQuestion.OptionD= input.OptionD;
            gramerQuestion.CorrectOption = input.CorrectOption;

            var gramerQuestionFromDb = await _gramerQuestions.UpdateAsync(gramerQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new GramerQuestionCreateOutputDto
            {
                Id = gramerQuestionFromDb.Id,
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
        public async Task Delete(int id)
        {
            await _gramerQuestions.DeleteAsync(id);
        }

    }

}
