using System.Linq.Expressions;

namespace APICatalogo.Repositories
{
    public interface IRepository<T> //vai ser herdada pelos repositorios
    {
        //cuidado para nao violar o principio ISP
        
        IEnumerable<T> GetAll(); //representa uma consulta //conculta em memoria
        T? Get(Expression<Func<T, bool>> predicate); //consulta em Lambda
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
