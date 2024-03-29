﻿using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.ListeningQuestions.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.ListeningQuestions
{
    [AbpAuthorize(PermissionNames.Admin)]
    public class ListeningQuestionsAppService : ApplicationService
    {
        private readonly IRepository<ListeningQuestion> _listeningQuestions;

        public ListeningQuestionsAppService(IRepository<ListeningQuestion> listeningQuestions)
        {
            _listeningQuestions = listeningQuestions;
        }

        [HttpPost]
        public async Task<ListeningQuestionCreateOutputDto> Create(ListeningQuestionCreateDto input)
        {
            ListeningQuestion listeningQuestion = new ListeningQuestion
            {
                LessonId = input.LessonId,
                EnglishSentence = input.EnglishSentence,
            };

            var listeningQuestionFromDb = await _listeningQuestions.InsertAsync(listeningQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new ListeningQuestionCreateOutputDto
            {
                Id = listeningQuestionFromDb.Id,
                LessonId = listeningQuestionFromDb.LessonId,
                EnglishSentence = listeningQuestionFromDb.EnglishSentence,
            };
        }

        [HttpPut]
        public async Task<ListeningQuestionCreateOutputDto> Update(ListeningQuestionUpdateDto input)
        {
            var listeningQuestion = await _listeningQuestions.GetAsync(input.Id);
            listeningQuestion.EnglishSentence= input.EnglishSentence;

            var listeningQuestionFromDb = await _listeningQuestions.UpdateAsync(listeningQuestion);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new ListeningQuestionCreateOutputDto
            {
                Id = listeningQuestionFromDb.Id,
                LessonId = listeningQuestionFromDb.LessonId,
                EnglishSentence = listeningQuestionFromDb.EnglishSentence,
            };
        }

        [HttpDelete]
        public async Task Delete(int input)
        {
            await _listeningQuestions.DeleteAsync(input);
        }
    }

}
