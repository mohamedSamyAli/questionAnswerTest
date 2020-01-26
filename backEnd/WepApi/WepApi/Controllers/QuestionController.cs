using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using WepApi.Models;
using WepApi.MyRepository;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using WepApi.NewFolder;

namespace WepApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {

        private  QuestionRepo questionRepo;
        private StringValues authorizationToken;

        public QuestionController(AppDbContext _MyDb)
        {
            questionRepo = new QuestionRepo(_MyDb);
        }

        [HttpGet("getall")]
        public IQueryable<Question> Get()
        {
            return questionRepo.FindAll() ;
        }

        [HttpGet("getqAnswers")]
        public IQueryable<Question> GetquestionWithAnswers()
        {
            return questionRepo.GetAnswers();
        }

        [HttpPost("addquestion")]
        //[Authorize]
        public int AddQuestion(Question question)
        {
            question.date = DateTime.MinValue;
            question.userName = Helpers.GetUserName(HttpContext);
            return questionRepo.Create(question);
        }

    }

   

}
