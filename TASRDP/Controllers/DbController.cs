using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TASRDP.Controllers
{
    using TASRDP.Controllers.RequestModels;
    using TASRDP.Services;

    [ApiController]
    [Route("/[controller]")]
    public sealed class DbController : ControllerBase
    {
        private readonly IDbService _dbService;

        public DbController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("GetQuestion")]
        public ActionResult<string> GetQuestion([FromBody] QuestionRequest request)
        {
            return JsonSerializer.Serialize(_dbService.GetQuestion(request.QuestionId));
        }

        [HttpPut("SaveAnswer")]
        public ActionResult SaveAnswer([FromBody] SaveAnswerRequest request)
        {
            _dbService.SaveAnswer(request.InterviewId, request.AnswerIds);
            return Ok();
        }
    }
}
