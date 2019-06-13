using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioAplicativo.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required(ErrorMessage ="Informe o nome do item")]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Informe o tipo do item")]
        [DisplayName("Tipo")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Informe uma descrição para o item")]
        [DisplayName("Descrição")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Informe a quantidade do item")]
        [DisplayName("Quantidade")]
        public int Und { get; set; }
        
    }
}
