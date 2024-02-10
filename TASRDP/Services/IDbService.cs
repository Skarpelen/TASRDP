namespace TASRDP.Services
{
    using TASRDP.Models;

    public interface IDbService
    {
        /// <summary>
        /// Ищет вопрос <see cref="Question"/> по его Id
        /// </summary>
        /// <param name="questionId">Id вопроса</param>
        /// <returns>Найденный вопрос или null</returns>
        Question? GetQuestion(int questionId);
        
        /// <summary>
        /// Сохранить ответы(1 или несколько)
        /// </summary>
        /// <param name="interviewId">Id проводимого интервью</param>
        /// <param name="answerIds">Id ответов</param>
        void SaveAnswer(int interviewId, int[] answerIds);
    }
}
