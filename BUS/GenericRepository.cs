using AutoMapper;
using BUS.Maps;
using DAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public static Context _context;
        public DbSet<T> table;
        static MapperConfiguration config = new MapperConfiguration(cfg => {
            cfg.AddProfile(new MappingProfiles());
        });
        public IMapper mapper;
        public GenericRepository()
        {
            _context = new Context();
            this.table = _context.Set<T>();
            mapper = new Mapper(config);
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public T Insert(T obj)
        {
            table.Add(obj);
            _context.SaveChanges();
            return obj;
        }
        public T Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
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
