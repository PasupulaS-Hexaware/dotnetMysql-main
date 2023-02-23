using System.Collections.Generic;

namespace dotnetMysql.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
