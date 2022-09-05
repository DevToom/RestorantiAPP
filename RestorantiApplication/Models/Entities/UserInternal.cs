using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities
{
    public class UserInternal
    {
        public UserInternal()
        {
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            ConfirmPassword = string.Empty;
        }

        public int Id { get; set; }

        /// <summary>
        /// Nome do usuário ( administrador ou funcionário )
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Telefone do usuário
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email do usuário
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Tipo de perfil
        /// </summary>
        public EProfile Profile { get; set; }

        /// <summary>
        /// Nome de usuário
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Confirmação da senha do usuário
        /// </summary>
        public string ConfirmPassword { get; set; }

    }

    public enum EProfile
    {
        Administrador = 0,
        Comum = 1
    }
}
