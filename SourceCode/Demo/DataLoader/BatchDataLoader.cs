using System;

namespace Demo.DataLoader
{
    public class BatchDataLoader<TId, TEntity> { };

    //public class PersonBatchDataLoader : BatchDataLoader<string, Person>
    //{
    //    private readonly IPersonRepository _repository;

    //    public PersonBatchDataLoader(
    //        IPersonRepository repository,
    //        IBatchScheduler batchScheduler,
    //        DataLoaderOptions<string>? options = null)
    //        : base(batchScheduler, options)
    //    {
    //        _repository = repository;
    //    }

    //    protected override async Task<IReadOnlyDictionary<string, Person>> LoadBatchAsync(
    //        IReadOnlyList<string> keys,
    //        CancellationToken cancellationToken)
    //    {
    //        // instead of fetching one person, we fetch multiple persons
    //        var persons = await _repository.GetPersonByIds(keys);
    //        return persons.ToDictionary(x => x.Id);
    //    }
    //}
}
