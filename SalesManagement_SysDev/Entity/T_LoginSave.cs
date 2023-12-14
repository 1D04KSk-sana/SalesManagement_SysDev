using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    internal class T_LoginSave
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaveId { get; set; }

        [Required]
        public int SaveEmployeeID { get; set; }        //社員ID
        public string SaveSinghUpPass { get; set; }    //パスワード
    }
}
