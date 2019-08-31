namespace StudentSystem.Data.Contracts.Builders
{
    using System.Collections.Generic;

    public interface IBuilder<TFrom, To>
        where TFrom : class
        where To : class
    {
        IEnumerable<To> Build(IEnumerable<TFrom> from);
    }
}