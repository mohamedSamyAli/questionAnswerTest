using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Models;

namespace WepApi.MyRepository
{
    public class QuestionRepo: RepositoryBase<Question>
    {
        AppDbContext _repositoryContext;

        public QuestionRepo(AppDbContext repositoryContext)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IQueryable<Question> GetAnswers()
        {
            return _repositoryContext.questions.Include(e => e.answers);
        }
    }
}
