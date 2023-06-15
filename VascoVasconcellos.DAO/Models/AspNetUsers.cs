using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using VascoVasconcellos.DAO.Models.VM;

namespace VascoVasconcellos.DAO.Models
{
    public class AspNetUsers : IdentityUser
    {
        [InverseProperty("IdAspNetUserNavigation")]
        public virtual Usuario Usuario { get; set; }
    }

    public static class UserExtensions
    {

        public static AspNetUsers[] ObterTodos(
            this UserManager<AspNetUsers> userManager
        )
        {
            return userManager.Users.Include(x => x.Usuario).ToArray();
        }

        public static AspNetUsers ObterPorId(
            this UserManager<AspNetUsers> userManager,
            string id,
            string includeProperties = "Usuario"
        )
        {
            var query = userManager.Users.AsQueryable();

            foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(x => x.Id == id);
        }

        public static AspNetUsers ObterPorEmail(
            this UserManager<AspNetUsers> userManager,
            string email,
            string includeProperties = ""
        )
        {
            var query = userManager.Users.AsQueryable();

            foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(x => x.Email == email);
        }

        public static AspNetUsers ObterPorUserName(
            this UserManager<AspNetUsers> userManager,
            string userName,
            string includeProperties = ""
        )
        {
            var query = userManager.Users.AsQueryable();

            foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(x => x.UserName == userName);
        }

        public static AspNetUsers ObterPorIdUsuario(
            this UserManager<AspNetUsers> userManager,
            int idUsuario,
            string includeProperties = ""
        )
        {
            var query = userManager.Users.AsQueryable();

            foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(x => x.Usuario.Id == idUsuario);
        }

    }

}