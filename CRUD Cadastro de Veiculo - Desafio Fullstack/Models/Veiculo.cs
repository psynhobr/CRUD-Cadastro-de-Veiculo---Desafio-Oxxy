
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Cadastro_de_Veiculo___Desafio_Fullstack.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencher a Placa do veiculo", AllowEmptyStrings = false)]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Preencher o Renavam", AllowEmptyStrings = false)]
        public string Renavam { get; set; }
        [Required(ErrorMessage = "Preencher o Nome", AllowEmptyStrings = false)]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencher o CPF do proprietario", AllowEmptyStrings = false)]
        public string Cpf { get; set; }
        public string Imagem { get; set; }
    }
}