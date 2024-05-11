
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
        [StringLength(11, MinimumLength = 10,  ErrorMessage = "O telefone deve ter entre 10 e 11 números")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O estado é obrigatório")]
        public string StateName { get; set; } = "";

        public int StateId { get; set; }
    }
}