using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.UI;
using LanguageLearning.AppServices.Exams.Dtos;
using LanguageLearning.AppServices.GramerQuestions.Dtos;
using LanguageLearning.AppServices.ListeningQuestions.Dtos;
using LanguageLearning.AppServices.SpeakingQuestions.Dtos;
using LanguageLearning.AppServices.VocabularyQuestions.Dtos;
using LanguageLearning.AppServices.WritingQuestions.Dtos;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly int PassGrade = 60;

        private readonly IRepository<Lesson> _lessonRepository;
        private readonly IRepository<GramerQuestion> _gramerQuestion;
        private readonly IRepository<WritingQuestion> _writingQuestion;
        private readonly IRepository<SpeakingQuestion> _speakingQuestion;
        private readonly IRepository<ListeningQuestion> _listeningQuestion;
        private readonly IRepository<VocabularyQuestion> _vocabularyQuestion;
        private readonly IRepository<UserCurrentLesson> _userCurrentLesson;
        private readonly IRepository<Exam> _examRepository;
        Random random = new Random();


        public ExamAppService(IRepository<Lesson> lessonRepository, IRepository<GramerQuestion> gramerQuestion,
            IRepository<WritingQuestion> writingQuestion, IRepository<SpeakingQuestion> speakingQuestion,
            IRepository<ListeningQuestion> listeningQuestion, IRepository<VocabularyQuestion> vocabularyQuestion, IRepository<UserCurrentLesson> userCurrentLesson, IRepository<Exam> examRepository)
        {
            _lessonRepository = lessonRepository;
            _gramerQuestion = gramerQuestion;
            _writingQuestion = writingQuestion;
            _speakingQuestion = speakingQuestion;
            _listeningQuestion = listeningQuestion;
            _vocabularyQuestion = vocabularyQuestion;
            _userCurrentLesson = userCurrentLesson;
            _examRepository = examRepository;
        }

        [HttpGet]
        public async Task<ExamDto> GetExamByLesson(int LessonId)
        {
            var lesson = await _lessonRepository.FirstOrDefaultAsync(LessonId);
            if (lesson == null)
            {
                throw new UserFriendlyException(LessonId + " numaralı lesson bulunamadı.");
            }

            List<GramerQuestionDto> GramerQuestions = _gramerQuestion.GetAll().Where(p => p.LessonId == LessonId)
                .ToList().Select(u => new GramerQuestionDto
                {
                    Sentence = u.Sentence,
                    OptionA = u.OptionA,
                    OptionB = u.OptionB,
                    OptionC = u.OptionC,
                    OptionD = u.OptionD,
                    CorrectOption = u.CorrectOption,
                }).ToList();

            List<WritingQuestionDto> WritingQuestions = _writingQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList()
                .ToList().Select(u => new WritingQuestionDto
                {
                    EnglishSentence = u.EnglishSentence,
                    TurkishSentence = u.TurkishSentence,
                }).ToList();

            List<SpeakingQuestionDto> SpeakingQuestions = _speakingQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList()
                .ToList().Select(u => new SpeakingQuestionDto
                {
                    EnglishSentence = u.EnglishSentence,
                }).ToList();

            List<ListeningQuestionDto> ListeningQuestions = _listeningQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList()
                .ToList().Select(u => new ListeningQuestionDto
                {
                    EnglishSentence = u.EnglishSentence,
                }).ToList();

            List<VocabularyQuestionDto> VocabularyQuestions = _vocabularyQuestion.GetAll().Where(p => p.LessonId == LessonId).ToList()
                .ToList().Select(u => new VocabularyQuestionDto
                {
                    Word = u.Word,
                    OptionA = u.OptionA,
                    OptionB = u.OptionB,
                    OptionC = u.OptionC,
                    OptionD = u.OptionD,
                    CorrectOption = u.CorrectOption,
                }).ToList();
            ExamDto examDto = new ExamDto();

            if (GramerQuestions.Count < 2 || WritingQuestions.Count < 2 || SpeakingQuestions.Count < 2 || ListeningQuestions.Count < 2 || GramerQuestions.Count < 2 || VocabularyQuestions.Count < 2)
            {
                throw new UserFriendlyException("Bu lessonu sorularıyla beraber alabilmek için bütün tipte sorulardan en az ikişer tane olmalıdır.");
            }

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
        public async Task<ExamGetResultDto> CreateExamResultAndUpdateExamPassedValue(ExamCreateDto input)
        {

            var userCurrentLesson = await _userCurrentLesson.GetAll().Where(p => p.LessonId == input.LessonId).Where(q => q.UserId == (long)AbpSession.UserId).FirstOrDefaultAsync();

            if (input.Grade >= PassGrade)
            {
                userCurrentLesson.IsPassed = true;
            }
            await _userCurrentLesson.UpdateAsync(userCurrentLesson);

            Exam exam = new Exam
            {
                LessonId = input.LessonId,
                UserId = (long) AbpSession.UserId,
                Grade = input.Grade,
            };

            Exam examFromDb = await _examRepository.InsertAsync(exam);
            await CurrentUnitOfWork.SaveChangesAsync();

            return new ExamGetResultDto
            {
                Id = examFromDb.Id,
                LessonId = examFromDb.LessonId,
                Grade = examFromDb.Grade,
                IsPassed = userCurrentLesson.IsPassed,
            };
        }

    }
}
