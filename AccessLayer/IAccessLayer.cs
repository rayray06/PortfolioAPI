using System.Collections.Generic;

namespace Portfolio.AccessLayer
{
    public interface IAccessLayer<T>
    {
        List<T>      List();
        T            Get();
        T         Add();
        bool         Validate(T entity);
        void         Remove();
        void         Update();
    }
}