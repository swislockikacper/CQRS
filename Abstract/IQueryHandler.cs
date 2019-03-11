namespace CQRS.Abstract
{
    public interface IQueryHandler
    {
    }

    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Query(TQuery query);
    }
}
