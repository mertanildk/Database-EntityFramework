﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository <T> where T :class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filtre=null ====filtre vermesen de olur  demek
        T Get(Expression<Func<T, bool>> filter);//nullu sildik şimdi bütün hepsini verir.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
