using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_SUGGESSIONRepository : IRepository<HP_SUGGESSION>
    {
        void Update(HP_SUGGESSION objData);
    }
}
