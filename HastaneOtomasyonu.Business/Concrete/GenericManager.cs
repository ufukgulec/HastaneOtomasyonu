using HastaneOtomasyonu.Business.Abstract;
using HastaneOtomasyonu.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> genericRepository;

        public GenericManager(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        /// <summary>
        /// Generic Ekleme
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Varlık</returns>
        public T Create(T entity)
        {
            return genericRepository.Create(entity);
        }
        /// <summary>
        /// Gelen Id'ye göre varlık çeker.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Varlık</returns>
        public T Get(int id)
        {
            return genericRepository.Get(id);
        }
        /// <summary>
        /// Tüm liste döner.
        /// </summary>
        /// <returns>Varlık Listesi</returns>
        public IQueryable<T> GetAll()
        {
            return genericRepository.GetAll();
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return genericRepository.GetAll(expression);
        }
        /// <summary>
        /// Gelen Id'ye göre varlık siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True False</returns>
        public bool Remove(int id)
        {
            return genericRepository.Remove(id);
        }
        /// <summary>
        /// Gelen varlığı siler.
        /// </summary>
        /// <param name="entity">Varlık</param>
        /// <returns>True False</returns>
        public bool Remove(T entity)
        {
            return genericRepository.Remove(entity);
        }
        /// <summary>
        /// Gelen varlığı günceller.
        /// </summary>
        /// <param name="entity">Varlık</param>
        /// <returns>Varlık</returns>
        public T Update(T entity)
        {
            return genericRepository.Update(entity);
        }
    }
}
