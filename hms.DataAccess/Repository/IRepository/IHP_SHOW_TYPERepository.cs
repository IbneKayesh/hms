using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_SHOW_TYPERepository : IRepository<HP_SHOW_TYPE>
    {
        void Update(HP_SHOW_TYPE objData);
    }
}
