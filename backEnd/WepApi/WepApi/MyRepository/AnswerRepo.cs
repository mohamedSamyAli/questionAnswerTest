using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Models;

namespace WepApi.MyRepository
{
    public class AnswerRepo:RepositoryBase<Answer>
    {
        private AnswerRepo answerRepo;
        public AnswerRepo(AppDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
