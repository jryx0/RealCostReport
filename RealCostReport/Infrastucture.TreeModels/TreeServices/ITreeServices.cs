using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.TreeModels
{
    public interface ITreeServices<T> where T : class
    {
        IQueryable<T> QueryBy(Expression<Func<T, bool>> predict);
        IQueryable<T> QueryByWithDescendants(Expression<Func<T, List<T>>> include, Expression<Func<T, bool>> predict);
        void SaveChanges();
    }
}
