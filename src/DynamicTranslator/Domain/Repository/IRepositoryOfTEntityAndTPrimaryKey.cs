﻿using System.Threading.Tasks;

namespace DynamicTranslator.Domain.Repository
{
    public interface IRepository<TEntity, in TPrimaryKey> : IRepository where TEntity : class
    {
        TEntity Get(TPrimaryKey id);

        Task<TEntity> GetAsync(TPrimaryKey id);

        TEntity Insert(TEntity entity, TPrimaryKey key);

        Task<TEntity> InsertAsync(TEntity entity, TPrimaryKey key);
    }
}