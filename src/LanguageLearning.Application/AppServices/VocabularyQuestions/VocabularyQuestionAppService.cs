using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.VocabularyQuestions.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.VocabularyQuestions
{
    [AbpAuthorize(PermissionNames.Admin)]
    public class VocabularyQuestionAppService : ApplicationService
    {
        private readonly IRepository<VocabularyQuestion> _vocabularyRepository;

        public VocabularyQuestionAppService(IRepository<VocabularyQuestion> vocabularyQuestion)
        {
            _vocabularyRepository = vocabularyQuestion;
        }

        [HttpPost]
        public async Task<VocabularyQuestionCreateOutputDto> Create(VocabularyQuestionCreateDto input)
        {
            VocabularyQuestion vocabularyQuestion = new VocabularyQuestion
            {
                LessonId = input.LessonId,
                Word = input.Word,
                OptionA = input.OptionA,
                OptionB = input.OptionB,
                OptionC = input.OptionC,
                OptionD = input.OptionD,
                CorrectOption = input.CorrectOption
            };

            var vocabularyQuestionFromDb = await _vocabularyRepository.InsertAsync(vocabularyQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new VocabularyQuestionCreateOutputDto
            {
                Id = vocabularyQuestionFromDb.Id,
                LessonId = vocabularyQuestionFromDb.LessonId,
                Word = vocabularyQuestionFromDb.Word,
                OptionA = vocabularyQuestionFromDb.OptionA,
                OptionB = vocabularyQuestionFromDb.OptionB,
                OptionC = vocabularyQuestionFromDb.OptionC,
                OptionD = vocabularyQuestionFromDb.OptionD,
                CorrectOption = vocabularyQuestionFromDb.CorrectOption
            };
        }

        [HttpPut]
        public async Task<VocabularyQuestionCreateOutputDto> Update(VocabularyQuestionUpdateDto input)
        {
            VocabularyQuestion vocabularyQuestion = await _vocabularyRepository.GetAsync(input.Id);
            vocabularyQuestion.Word= input.Word;
            vocabularyQuestion.OptionA= input.OptionA;
            vocabularyQuestion.OptionB= input.OptionB;
            vocabularyQuestion.OptionC= input.OptionC;
            vocabularyQuestion.OptionD= input.OptionD;
            vocabularyQuestion.CorrectOption= input.CorrectOption;

            var vocabularyQuestionFromDb = await _vocabularyRepository.UpdateAsync(vocabularyQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new VocabularyQuestionCreateOutputDto
            {
                Id = vocabularyQuestionFromDb.Id,
                LessonId = vocabularyQuestionFromDb.LessonId,
                Word = vocabularyQuestionFromDb.Word,
                OptionA = vocabularyQuestionFromDb.OptionA,
                OptionB = vocabularyQuestionFromDb.OptionB,
                OptionC = vocabularyQuestionFromDb.OptionC,
                OptionD = vocabularyQuestionFromDb.OptionD,
                CorrectOption = vocabularyQuestionFromDb.CorrectOption
            };
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _vocabularyRepository.DeleteAsync(id);
        }
    }

}
