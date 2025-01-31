﻿using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll(Expression<Func<T, bool>>? filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    
    //
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
    Task<T> GetAsync(Expression<Func<T, bool>>? filter = null);
     void AddAsync(T entity);
     void DeleteAsync(T entity);
     void UpdateAsync(T entity);


}