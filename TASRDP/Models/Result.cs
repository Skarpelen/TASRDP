using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TASRDP.Models
{
    [Table("results")]
    public sealed class Result
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [Column("resultid")]
        public int ResultId { get; set; }

        /// <summary>
        /// Результаты какого интервью
        /// </summary>
        [Column("interviewid")]
        [ForeignKey("interviews")]
        public int InterviewId { get; set; }

        /// <summary>
        /// Дата проведения
        /// </summary>
        [Column("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Список выбранных ответов
        /// </summary>
        [Column("pickedanswerids")]
        public int[] PickedAnswerIds { get; set; }

        public Interview Interview { get; set; }
    }
}
