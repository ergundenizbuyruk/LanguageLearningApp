using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using LanguageLearning.AppServices.Exams.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Exams
{
    [AbpAuthorize]
    public class ExamAppService : ApplicationService
    {
        private readonly IRepository<Exam> _examRepository;
        private readonly IRepository<GramerQuestion> _gramerQuestion;
        private readonly IRepository<WritingQuestion> _writingQuestion;
        private readonly IRepository<SpeakingQuestion> _speakingQuestion;
        private readonly IRepository<ListeningQuestion> _listeningQuestion;
        private readonly IRepository<VocabularyQuestion> _vocabularyQuestion;
        Random random = new Random();


        public ExamAppService(IRepository<Exam> examRepository, IRepository<GramerQuestion> gramerQuestion, IRepository<WritingQuestion> writingQuestion, IRepository<SpeakingQuestion> speakingQuestion, IRepository<ListeningQuestion> listeningQuestion, IRepository<VocabularyQuestion> vocabularyQuestion, IObjectMapper mapper)
        {
            _examRepository = examRepository;
            _gramerQuestion = gramerQuestion;
            _writingQuestion = writingQuestion;
            _speakingQuestion = speakingQuestion;
            _listeningQuestion = listeningQuestion;
            _vocabularyQuestion = vocabularyQuestion;
        }

        [HttpGet("{LessonId}")]
        public async Task<ExamDto> GetExamByLesson(int LessonId)
        {

            List<GramerQuestion> GramerQuestions = _gramerQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList();
            List<WritingQuestion> WritingQuestions = _writingQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList();
            List<SpeakingQuestion> SpeakingQuestions = _speakingQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList();
            List<ListeningQuestion> ListeningQuestions = _listeningQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList();
            List<VocabularyQuestion> VocabularyQuestions = _vocabularyQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList();

            ExamDto examDto = new ExamDto();

            int r = random.Next(GramerQuestions.Count);
            examDto.GramerQuestions.Add(GramerQuestions[r]);
            GramerQuestions.RemoveAt(r);

            r = random.Next(GramerQuestions.Count);
            examDto.GramerQuestions.Add(GramerQuestions[r]);

            r = random.Next(WritingQuestions.Count);
            examDto.WritingQuestions.Add(WritingQuestions[r]);
            WritingQuestions.RemoveAt(r);

            r = random.Next(WritingQuestions.Count);
            examDto.WritingQuestions.Add(WritingQuestions[r]);

            r = random.Next(SpeakingQuestions.Count);
            examDto.SpeakingQuestions.Add(SpeakingQuestions[r]);
            SpeakingQuestions.RemoveAt(r);

            r = random.Next(SpeakingQuestions.Count);
            examDto.SpeakingQuestions.Add(SpeakingQuestions[r]);

            r = random.Next(ListeningQuestions.Count);
            examDto.ListeningQuestions.Add(ListeningQuestions[r]);
            ListeningQuestions.RemoveAt(r);

            r = random.Next(ListeningQuestions.Count);
            examDto.ListeningQuestions.Add(ListeningQuestions[r]);

            r = random.Next(VocabularyQuestions.Count);
            examDto.VocabularyQuestions.Add(VocabularyQuestions[r]);
            VocabularyQuestions.RemoveAt(r);

            r = random.Next(VocabularyQuestions.Count);
            examDto.VocabularyQuestions.Add(VocabularyQuestions[r]);

            return examDto;
        }

        [HttpPost]
        public async Task<ExamCreateOutputDto> ExamResult(ExamCreateDto input)
        {
            Exam exam = new Exam
            {
                LessonId = input.LessonId,
                UserId = input.UserId,
                Grade = input.Grade,
            };

            Exam examFromDb = await _examRepository.InsertAsync(exam);

            return new ExamCreateOutputDto
            {
                Id = examFromDb.Id,
                LessonId = examFromDb.LessonId,
                UserId = examFromDb.UserId,
                Grade = examFromDb.Grade
            };
        }

    }
}
