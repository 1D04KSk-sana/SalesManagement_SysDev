﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_ArrivalDetail
    {
        [Key]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArDetailID { get; set; }     //入荷詳細ID
        public int ArID { get; set; }           //入荷ID
        public int PrID { get; set; }           //商品ID
        public int ArQuantity { get; set; }	    //数量

        public virtual M_Product M_Product { get; set; }
        public virtual T_Arrival T_Arrival { get; set; }
    }
}
