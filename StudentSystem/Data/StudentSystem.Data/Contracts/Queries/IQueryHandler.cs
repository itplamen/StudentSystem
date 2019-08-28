﻿namespace StudentSystem.Data.Contracts.Queries
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }

    public interface IQueryHandler<TResult>
    {
        TResult Handle();
    }
}