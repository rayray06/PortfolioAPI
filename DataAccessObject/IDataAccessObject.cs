using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data.AccessObjects
{
    public interface IDataAccessObject
    {
          T            Get<T>       (params object[] args) where T: class;
          List<T>      List<T>      (params object[] args) where T: class;
          void         Remove<T>    (params object[] args) where T: class;
          T         Add<T>       (params object[] args) where T: class;
          void         Validate<T>  (params object[] args) where T: class;
          void Save();
          void      Update<T>    (params object[] args) where T: class;
          DbContext GetContext<T>() where T: class;
    }
}