using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Exams.Dtos;
using LanguageLearning.AppServices.Lessons.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using LanguageLearning.Domain.Questions;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.UI;

namespace LanguageLearning.AppServices.Lessons
{
    
    public class LessonAppService : AsyncCrudAppService<Lesson, LessonDto, int, LessonDto, LessonCreateDto, LessonUpdateDto>, ILessonAppService
    {
        private readonly IRepository<Exam> _examRepository;
        private readonly IRepository<GramerQuestion> _gramerQuestion;
        private readonly IRepository<WritingQuestion> _writingQuestion;
        private readonly IRepository<SpeakingQuestion> _speakingQuestion;
        private readonly IRepository<ListeningQuestion> _listeningQuestion;
        private readonly IRepository<VocabularyQuestion> _vocabularyQuestion;
        private readonly IRepository<Lesson> _lessonRepository;
        private readonly IRepository<UserCurrentLesson> _userCurrentLesson;
        Random random = new Random();

        public LessonAppService(IRepository<Lesson, int> repository, IRepository<Exam> examRepository, IRepository<GramerQuestion> gramerQuestion, IRepository<WritingQuestion> writingQuestion, IRepository<SpeakingQuestion> speakingQuestion, IRepository<ListeningQuestion> listeningQuestion, IRepository<VocabularyQuestion> vocabularyQuestion, IRepository<Lesson> lessonRepository, IRepository<UserCurrentLesson> userCurrentLesson) : base(repository)
        {
            _examRepository = examRepository;
            _gramerQuestion = gramerQuestion;
            _writingQuestion = writingQuestion;
            _speakingQuestion = speakingQuestion;
            _listeningQuestion = listeningQuestion;
            _vocabularyQuestion = vocabularyQuestion;
            _lessonRepository = lessonRepository;
            _userCurrentLesson = userCurrentLesson;
        }

        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
        public override Task<PagedResultDto<LessonDto>> GetAllAsync(LessonDto input)
        {
            return null;
        }

        public async Task<List<LessonGetAllByUserDto>> GetAllLessonsByUserWithPassAttribute(int UserId)
        {
            var allLessonList = _userCurrentLesson.GetAll().Include(p => p.Lesson).Include(p => p.User)
                .Where(p => p.UserId == UserId).ToListAsync().Result.Select(u => new LessonGetAllByUserDto
                {
                    Lesson = u.Lesson,
                    IsPass = u.IsPassed,
                }).ToList();

            return allLessonList;
        }

        public override async Task<LessonDto> GetAsync(EntityDto<int> input)
        {
            List<GramerQuestion> GramerQuestions = _gramerQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList();
            List<WritingQuestion> WritingQuestions = _writingQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList();
            List<SpeakingQuestion> SpeakingQuestions = _speakingQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList();
            List<ListeningQuestion> ListeningQuestions = _listeningQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList();
            List<VocabularyQuestion> VocabularyQuestions = _vocabularyQuestion.GetAll().Where(p => p.LessonId == input.Id).ToList();

            Lesson lesson = await _lessonRepository.GetAll().Include(p => p.Comments).Where(p => p.Id == input.Id).FirstOrDefaultAsync();

            int r = random.Next(GramerQuestions.Count);
            lesson.GramerQuestions.Add(GramerQuestions[r]);
            GramerQuestions.RemoveAt(r);

            r = random.Next(GramerQuestions.Count);
            lesson.GramerQuestions.Add(GramerQuestions[r]);

            r = random.Next(WritingQuestions.Count);
            lesson.WritingQuestions.Add(WritingQuestions[r]);
            WritingQuestions.RemoveAt(r);

            r = random.Next(WritingQuestions.Count);
            lesson.WritingQuestions.Add(WritingQuestions[r]);

            r = random.Next(SpeakingQuestions.Count);
            lesson.SpeakingQuestions.Add(SpeakingQuestions[r]);
            SpeakingQuestions.RemoveAt(r);

            r = random.Next(SpeakingQuestions.Count);
            lesson.SpeakingQuestions.Add(SpeakingQuestions[r]);

            r = random.Next(ListeningQuestions.Count);
            lesson.ListeningQuestions.Add(ListeningQuestions[r]);
            ListeningQuestions.RemoveAt(r);

            r = random.Next(ListeningQuestions.Count);
            lesson.ListeningQuestions.Add(ListeningQuestions[r]);

            r = random.Next(VocabularyQuestions.Count);
            lesson.VocabularyQuestions.Add(VocabularyQuestions[r]);
            VocabularyQuestions.RemoveAt(r);

            r = random.Next(VocabularyQuestions.Count);
            lesson.VocabularyQuestions.Add(VocabularyQuestions[r]);

            return new LessonDto
            {
                Name = lesson.Name,
                Comments = lesson.Comments,
                VocabularyQuestions = lesson.VocabularyQuestions,
                GramerQuestions = lesson.GramerQuestions,
                ListeningQuestions = lesson.ListeningQuestions,
                WritingQuestions = lesson.WritingQuestions,
                SpeakingQuestions = lesson.SpeakingQuestions,
            };
        }
    }


    public interface ILessonAppService : IAsyncCrudAppService<LessonDto, int, LessonDto, LessonCreateDto, LessonUpdateDto> { }
}
