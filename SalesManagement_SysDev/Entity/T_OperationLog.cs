using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class T_OperationLog
    {
        [Key]
        public int OpHistoryID { get; set; }        //ログイン操作ID	
        public int? EmID { get; set; }               //社員ID

        [Required]
        public string FormName { get; set; }        //フォーム名
        public string OpDone { get; set; }          //操作内容
        public int OpDBID { get; set; }             //操作ID
        public DateTime OpSetTime { get; set; }     //操作日時

        public virtual M_Employee M_Employee { get; set; }
    }
}
