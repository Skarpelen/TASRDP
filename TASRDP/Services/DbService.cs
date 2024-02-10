namespace TASRDP.Services
{
    using TASRDP.Models;

    public class DbService : IDbService
    {
        private readonly AppDbContext _dbContext;

        public DbService(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public Question? GetQuestion(int questionId)
        {
            return _dbContext.Questions.FirstOrDefault(q => q.QuestionId == questionId);
        }

        public void SaveAnswer(int interviewId, int[] answerIds)
        {
            var result = _dbContext.Results.FirstOrDefault(r => r.InterviewId == interviewId);

            if (result is null)
            {
                result = new Result
                {
                    InterviewId = interviewId,
                    Date = DateTime.Now,
                    PickedAnswerIds = Array.Empty<int>()
                };

                _dbContext.Results.Add(result);
            }

            foreach (var answerId in answerIds)
            {
                var answer = _dbContext.Answers.FirstOrDefault(a => a.AnswerId == answerId);

                if (answer is null)
                {
                    return;
                }

                result.PickedAnswerIds = result.PickedAnswerIds.Concat(new[] { answerId }).ToArray();
            }

            _dbContext.SaveChanges();
        }
    }
}
