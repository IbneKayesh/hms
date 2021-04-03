using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_TOKENRepository : IRepository<HP_TOKEN>
    {
        void Update(HP_TOKEN objData);
    }
}
