using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using LanguageLearning.AppServices.Comments.Dtos;
using LanguageLearning.AppServices.GramerQuestions.Dtos;
using LanguageLearning.AppServices.Lessons.Dtos;
using LanguageLearning.AppServices.ListeningQuestions.Dtos;
using LanguageLearning.AppServices.SpeakingQuestions.Dtos;
using LanguageLearning.AppServices.VocabularyQuestions.Dtos;
using LanguageLearning.AppServices.WritingQuestions.Dtos;
using LanguageLearning.Authorization.Users;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Lessons
{
    [AbpAuthorize]
    public class LessonAppService : ApplicationService
    {
        private readonly IRepository<Exam> _examRepository;
        private readonly IRepository<GramerQuestion> _gramerQuestion;
        private readonly IRepository<WritingQuestion> _writingQuestion;
        private readonly IRepository<SpeakingQuestion> _speakingQuestion;
        private readonly IRepository<ListeningQuestion> _listeningQuestion;
        private readonly IRepository<VocabularyQuestion> _vocabularyQuestion;
        private readonly IRepository<Lesson> _lessonRepository;
        private readonly IRepository<UserCurrentLesson> _userCurrentLesson;
        private readonly IRepository<User, long> _userManager;

        Random random = new Random();

        public LessonAppService(IRepository<Lesson, int> repository, IRepository<Exam> examRepository, IRepository<GramerQuestion> gramerQuestion,
            IRepository<WritingQuestion> writingQuestion, IRepository<SpeakingQuestion> speakingQuestion, IRepository<ListeningQuestion> listeningQuestion,
            IRepository<VocabularyQuestion> vocabularyQuestion,
            IRepository<Lesson> lessonRepository, IRepository<UserCurrentLesson> userCurrentLesson, IRepository<User, long> userManager)
        {
            _examRepository = examRepository;
            _gramerQuestion = gramerQuestion;
            _writingQuestion = writingQuestion;
            _speakingQuestion = speakingQuestion;
            _listeningQuestion = listeningQuestion;
            _vocabularyQuestion = vocabularyQuestion;
            _lessonRepository = lessonRepository;
            _userCurrentLesson = userCurrentLesson;
            _userManager = userManager;
        }



        public async Task<List<LessonGetAllByUserAndByLanguageOutputDto>> GetAllLessonsByUserAndByLanguageWithPassAttribute(LessonGetAllByUserAndByLanguageInputDto input)
        {
            var allLessonList = _userCurrentLesson.GetAll().Include(p => p.Lesson).ThenInclude(p => p.Language)
                .Where(p => p.UserId == input.UserId).Where(p => p.Lesson.LanguageId == input.LanguageId)
                .ToListAsync().Result.Select(u => new LessonGetAllByUserAndByLanguageOutputDto
                {
                    LessonName = u.Lesson.Name,
                    LessonId = u.Lesson.Id,
                    IsPass = u.IsPassed,
                }).ToList();

            return allLessonList;
        }

        public async Task<LessonWithoutQuestionsDto> CreateAsync(LessonCreateDto input)
        {

            Lesson lesson = new Lesson
            {
                Name = input.Name,
                LanguageId = input.LanguageId
            };

            var lessonFromDb = await _lessonRepository.InsertAsync(lesson);
            await CurrentUnitOfWork.SaveChangesAsync();

            var allUser = _userManager.GetAll().Include(p => p.Lessons).ToList();
            foreach (var user in allUser)
            {
                user.Lessons.Add(lessonFromDb);
                await _userManager.UpdateAsync(user);

                var userCurrentLesson = new UserCurrentLesson
                {
                    UserId = user.Id,
                    LessonId = lessonFromDb.Id,
                    IsPassed = false,
                };
                await _userCurrentLesson.InsertAsync(userCurrentLesson);
            }

            return new LessonWithoutQuestionsDto
            {
                Id = lessonFromDb.Id,
                Name = lessonFromDb.Name,
            };
        }

        public async Task<LessonWithAllQuestionsDto> GetAsync(EntityDto<int> input)
        {
            List<GramerQuestionDto> GramerQuestions = _gramerQuestion.GetAll().Where(p => p.LessonId == input.Id)
                .ToList().Select(u => new GramerQuestionDto
                {
                    Sentence = u.Sentence,
                    OptionA = u.OptionA,
                    OptionB = u.OptionB,
                    OptionC = u.OptionC,
                    OptionD = u.OptionD,
                    CorrectOption = u.CorrectOption,
                }).ToList();

            List<WritingQuestionDto> WritingQuestions = _writingQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList()
                .ToList().Select(u => new WritingQuestionDto
                {
                    EnglishSentence = u.EnglishSentence,
                    TurkishSentence = u.TurkishSentence,
                }).ToList();

            List<SpeakingQuestionDto> SpeakingQuestions = _speakingQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList()
                .ToList().Select(u => new SpeakingQuestionDto
                {
                    EnglishSentence = u.EnglishSentence,
                }).ToList();

            List<ListeningQuestionDto> ListeningQuestions = _listeningQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList()
                .ToList().Select(u => new ListeningQuestionDto
                {
                    EnglishSentence = u.EnglishSentence,
                }).ToList();

            List<VocabularyQuestionDto> VocabularyQuestions = _vocabularyQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList()
                .ToList().Select(u => new VocabularyQuestionDto
                {
                    Word = u.Word,
                    OptionA = u.OptionA,
                    OptionB = u.OptionB,
                    OptionC = u.OptionC,
                    OptionD = u.OptionD,
                    CorrectOption = u.CorrectOption,
                }).ToList();

            Lesson lesson = await _lessonRepository.GetAll().Include(p => p.Comments)
                .Where(p => p.Id == input.Id).FirstOrDefaultAsync();

            LessonWithAllQuestionsDto lessonWithAllQuestionsDto = new LessonWithAllQuestionsDto();

            int r = random.Next(GramerQuestions.Count);
            lessonWithAllQuestionsDto.GramerQuestions.Add(GramerQuestions[r]);
            GramerQuestions.RemoveAt(r);

            r = random.Next(GramerQuestions.Count);
            lessonWithAllQuestionsDto.GramerQuestions.Add(GramerQuestions[r]);

            r = random.Next(WritingQuestions.Count);
            lessonWithAllQuestionsDto.WritingQuestions.Add(WritingQuestions[r]);
            WritingQuestions.RemoveAt(r);

            r = random.Next(WritingQuestions.Count);
            lessonWithAllQuestionsDto.WritingQuestions.Add(WritingQuestions[r]);

            r = random.Next(SpeakingQuestions.Count);
            lessonWithAllQuestionsDto.SpeakingQuestions.Add(SpeakingQuestions[r]);
            SpeakingQuestions.RemoveAt(r);

            r = random.Next(SpeakingQuestions.Count);
            lessonWithAllQuestionsDto.SpeakingQuestions.Add(SpeakingQuestions[r]);

            r = random.Next(ListeningQuestions.Count);
            lessonWithAllQuestionsDto.ListeningQuestions.Add(ListeningQuestions[r]);
            ListeningQuestions.RemoveAt(r);

            r = random.Next(ListeningQuestions.Count);
            lessonWithAllQuestionsDto.ListeningQuestions.Add(ListeningQuestions[r]);

            r = random.Next(VocabularyQuestions.Count);
            lessonWithAllQuestionsDto.VocabularyQuestions.Add(VocabularyQuestions[r]);
            VocabularyQuestions.RemoveAt(r);

            r = random.Next(VocabularyQuestions.Count);
            lessonWithAllQuestionsDto.VocabularyQuestions.Add(VocabularyQuestions[r]);

            return new LessonWithAllQuestionsDto
            {
                Id = lesson.Id,
                Name = lesson.Name,
                Comments = ObjectMapper.Map<List<CommentGetDto>>(lesson.Comments),
                VocabularyQuestions = lessonWithAllQuestionsDto.VocabularyQuestions,
                GramerQuestions = lessonWithAllQuestionsDto.GramerQuestions,
                ListeningQuestions = lessonWithAllQuestionsDto.ListeningQuestions,
                WritingQuestions = lessonWithAllQuestionsDto.WritingQuestions,
                SpeakingQuestions = lessonWithAllQuestionsDto.SpeakingQuestions,
            };
        }
    }
}
