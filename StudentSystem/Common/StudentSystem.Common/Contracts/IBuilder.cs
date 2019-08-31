namespace StudentSystem.Common.Contracts
{
    using System.Collections.Generic;

    public interface IBuilder<TFrom, To>
        where TFrom : class
        where To : class
    {
        IEnumerable<To> Build(IEnumerable<TFrom> from);
    }
}