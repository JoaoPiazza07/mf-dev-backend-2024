using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Obrigatório informar o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano de fabricação .")]
        [Display(Name ="Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano de modelo.")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }


        //data = configurar nosso modelo para que o nosso framework, automaticamente, use essas informações na hora de criar no banco de dados e usar nas views
    }
}
