using dotnetMysql.Entities.Entities;


namespace dotnetMysql.Data.Interfaces
{
    public interface IEmployeeRepository : IGetById<Employee>, IGetAll<Employee>, ISave<Employee>, IUpdate<Employee>, IDelete<int>
    {
    }
}
