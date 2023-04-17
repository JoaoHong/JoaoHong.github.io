using System.ComponentModel.DataAnnotations;

namespace ConyGreen.DAO.Models.VM
{
	public class LogInVM
	{
		[Required(ErrorMessage = "O campo {0} é obrigatório!")]
		public string Nome { get; set; }

		[Display(Name = "Senha")]
		[Required(ErrorMessage = "O campo {0} é obrigatório!")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
