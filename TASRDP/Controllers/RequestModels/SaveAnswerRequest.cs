namespace TASRDP.Controllers.RequestModels
{
    /// <summary>
    /// Модель запроса для сохранения ответа
    /// </summary>
    public sealed class SaveAnswerRequest
    {
        /// <summary>
        /// Id интервью
        /// </summary>
        public int InterviewId { get; set; }

        /// <summary>
        /// Выбранные варианты ответа
        /// </summary>
        public int[] AnswerIds { get; set; }
    }
}