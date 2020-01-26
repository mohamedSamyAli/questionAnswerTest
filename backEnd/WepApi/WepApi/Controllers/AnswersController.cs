using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi.Models;
using WepApi.MyRepository;

namespace WepApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class AnswersController : ControllerBase
    {

        private AnswerRepo answerRepo;

        public AnswersController(AppDbContext _MyDb)
        {
            answerRepo = new AnswerRepo(_MyDb);
        }
        [HttpGet]
        public IQueryable<Answer> Get()
        {
            Answer a = new Answer() { body = "asdasdasdasd", date = DateTime.Now, questionFK = "613067ee-6344-4773-87d6-712508068028" };
            var n =answerRepo.Create(a);
            return answerRepo.FindAll();
        }

    }


}