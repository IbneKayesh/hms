using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_PRESCRIPTIONRepository : IRepository<HP_PRESCRIPTION>
    {
        void Update(HP_PRESCRIPTION objData);
    }
}
