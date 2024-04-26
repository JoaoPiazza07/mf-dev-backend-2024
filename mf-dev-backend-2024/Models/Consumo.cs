using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Consumos")]
    public class Consumo            //consumo de veículos               
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar a descrição!")]
        [Display (Name = "Descrição")]
        public string Descricao { get; set; } //com o o que voce consumiu
        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a valor!")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a kilometragem do veículo!")]
        public int km{ get; set;}
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo {get; set;}
        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        public int VeiculoId { get; set;}
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set;} //vitualização

    }

        public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Gas,
        Dissel 
    }
}
