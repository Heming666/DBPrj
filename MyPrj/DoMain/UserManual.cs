using Common.Models;
using Repository;

namespace MyPrj.DoMain
{
    public class UserManual
    {
        private readonly IRepository _repository;
        private readonly DBModel _dbModel;

        public UserManual(IRepository repository, DBModel dbModel)
        {
            _repository = repository;
            _dbModel = dbModel;
        }
    }
}