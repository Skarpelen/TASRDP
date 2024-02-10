namespace TASRDP.Controllers.RequestModels
{
    /// <summary>
    /// Модель запроса связанного с вопросом из базы данных
    /// </summary>
    public sealed class QuestionRequest
    {
        /// <summary>
        /// Id вопроса
        /// </summary>
        public int QuestionId { get; set; }
    }
}