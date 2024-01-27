using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam261.DbFirst
{
    [Table("OrderTbl")]
    public class OrderTbl
    { 
            [Key]
            public string itemCode { get; set; }

            public string ItemName { get; set; }

            public int ItemQty { get; set; }

            public string OrderDelivery { get; set; }

            public string OrderAddress { get; set; }

            public string PhoneNumber { get; set; }

        }
    }

