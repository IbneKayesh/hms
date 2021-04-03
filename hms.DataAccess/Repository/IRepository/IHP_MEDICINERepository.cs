using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_MEDICINERepository : IRepository<HP_MEDICINE>
    {
        void Update(HP_MEDICINE objData);

    }
}
