using Kreata.Backend.Context;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class StudentRepo<TDbConstext> : RepositoryBase<TDbConstext, Student>, IStudentRepo
        where TDbConstext : DbContext
    {
        public StudentRepo(IDbContextFactory<TDbConstext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
