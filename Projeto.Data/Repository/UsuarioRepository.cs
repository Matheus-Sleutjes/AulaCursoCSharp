using Microsoft.EntityFrameworkCore;
using Projeto.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repository
{
    public class UsuarioRepository
    {
        static List<Usuario> usuarios = new List<Usuario>();    

        public void Add(Usuario entidade) {
            usuarios.Add(entidade);
            //_context.Usuarios.Add(entidade);
            //_context.SaveChanges();
        }

        public void Delete(Usuario entidade) {
            usuarios.Remove(entidade);
            //_context.Usuarios.Remove(entidade);
            //_context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = usuarios.Where(u => u.Id == id).FirstOrDefault() ?? new Usuario();
            usuarios.Remove(entity);
            
            //_context.Usuarios.Remove(usuario);
            //_context.SaveChanges();
        }

        public void Update(int id, Usuario usuario) {
             Delete(id) ;
            usuarios.Add(usuario);

            //entidade.Nome = usuario.Nome;
            //entidade.Email = usuario.Email;
            //entidade.Senha = usuario.Senha;


            //_context.Usuarios.Update(entidade);
            //_context.SaveChanges();

        }

        public Usuario? Get(int id) {
            //var usuario = _context.Usuarios.AsNoTracking().Where(t =>  t.Id == id).FirstOrDefault();
            var usuario = usuarios.Where(u => u.Id == id).FirstOrDefault();
            return usuario;
        }

        public List<Usuario> GetAll()
        {
            var lista = usuarios.Take(100).ToList();
            //var lista = _context.Usuarios.AsNoTracking().Take(100).ToList();
            return lista;
        }
    }
}
