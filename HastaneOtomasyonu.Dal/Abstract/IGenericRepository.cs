using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Dal.Abstract
{
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Generic Ekleme
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Varlık</returns>
        T Create(T entity);
        /// <summary>
        /// Gelen Id'ye göre varlık çeker.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Varlık</returns>
        T Get(int id);
        /// <summary>
        /// IGenericRepository Tüm liste döner.
        /// </summary>
        /// <returns>Varlık Listesi</returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        /// <summary>
        /// Gelen Id'ye göre varlık siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True False</returns>
        bool Remove(int id);
        /// <summary>
        /// Gelen varlığı siler.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(T entity);
        /// <summary>
        /// Gelen varlığı günceller.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Varlık</returns>
        T Update(T entity);
    }
}
