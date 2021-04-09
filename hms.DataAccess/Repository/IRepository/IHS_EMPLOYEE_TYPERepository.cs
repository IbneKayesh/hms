using hms.DataModel;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_EMPLOYEE_TYPERepository : IRepository<HS_EMPLOYEE_TYPE>
    {
        void Update(HS_EMPLOYEE_TYPE objData);
        bool Delete(int id);
    }
}
