
using System.ComponentModel.DataAnnotations;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Core.DTO
{
    public class ContactDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [StringLength(15, MinimumLength = 14,  ErrorMessage = "O telefone deve ter entre 10 e 11 números")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email é inválido")]
        public string Email { get; set; }

        public Guid StateId { get; set; }

        public StateDto State { get; set; }
    }
}