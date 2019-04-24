using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _contexto;

        public UsuarioRepository(UsuarioDbContext ctx)
        {
            _contexto = ctx;
        }
        public void Add(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();
        }

        public Usuario Find(long id)
        {
            return _contexto.Usuario.FirstOrDefault(u => u.UsuarioId == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _contexto.Usuario.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Usuario.First(u => u.UsuarioId == id);
            _contexto.Usuario.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _contexto.Usuario.Update(usuario);
            _contexto.SaveChanges();
        }
    }
}