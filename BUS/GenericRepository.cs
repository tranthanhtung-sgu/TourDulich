using AutoMapper;
using BUS.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly Context _context = null;
        public readonly DbSet<T> table = null;
        static MapperConfiguration config = new MapperConfiguration(cfg => {
            cfg.AddProfile(new MappingProfiles());
        });
        public IMapper mapper = null;
        public GenericRepository()
        {
            this._context = new Context();
            table = _context.Set<T>();
            mapper = new Mapper(config);
        }
        public GenericRepository(Context _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public bool Insert(T obj)
        {
            table.Add(obj);
            var result = _context.SaveChanges() > 0;
            return result;
        }
        public bool Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            var result = _context.SaveChanges() > 0;
            return result;
        }
        public bool Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            var result = _context.SaveChanges() > 0;
            return result;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
