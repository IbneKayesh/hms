using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_DOCTOR_TYPERepository : IRepository<HS_DOCTOR_TYPE>
    {
        void Update(HS_DOCTOR_TYPE objData);
        bool Delete(int id);
    }
}
