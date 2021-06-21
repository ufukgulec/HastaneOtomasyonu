using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        /// <summary>
        /// Varlık ekleme
        /// </summary>
        /// <param name="entity">Varlık</param>
        /// <returns>Varlık</returns>
        T Create(T entity);
        /// <summary>
        /// Gelen Id'ye göre varlık getirme
        /// </summary>
        /// <param name="id">Varlık.Id</param>
        /// <returns>Varlık</returns>
        T Get(int id);
        /// <summary>
        /// Tüm liste döner.
        /// </summary>
        /// <returns>IQueryable Listesi</returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// Tüm liste sorguya göre döner.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>IQueryable Listesi</returns>
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
