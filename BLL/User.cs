using DAL;
using Model;
using BLL;

namespace BLL
{
    public class UserBL : IBusinessLogic
    {
        private IRespository _repo;
        public UserBL(IRespository p_repo)
        {
            _repo = p_repo;
        }
        public User AddUser(User p_user)
        {
           return _repo.AddUser(p_user);
        }
    }
}