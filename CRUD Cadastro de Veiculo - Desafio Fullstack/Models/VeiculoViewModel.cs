
using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace CRUD_Cadastro_de_Veiculo___Desafio_Fullstack.Models
{
    public class VeiculoViewModel
    {
        public Int32 Id { get; set; }
        [Required(ErrorMessage = "A placa do Veiculo é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Placa do Veiculo")]
        [MaxLength(8)]
        public String Placa { get; set; }
        [MaxLength(11)]
        [Required(ErrorMessage = "Renavam do Veiculo é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Renavam do veiculo")]
        public String Renavam { get; set; }
        [Required(ErrorMessage = "Informe o CPF do cliente", AllowEmptyStrings = false)]
        [Display(Name = "CPF")]
        [MaxLength(11)]
        public String Cpf { get; set; }
        [Required(ErrorMessage = "Informe o nome do cliente", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        [MaxLength(150)]
        public String Nome { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}