using System.ComponentModel.DataAnnotations;

namespace Exam261.Model
{
    public class Order
    {
            public string itemCode { get; set; }

            public string ItemName { get; set; }

            public int ItemQty { get; set; }

            public string OrderAddress { get; set; }

            public string PhoneNumber { get; set; }
        }

        public class Order2
        {

            public string ItemName { get; set; }

            public int ItemQty { get; set; }

            public string OrderAddress { get; set; }

            public string PhoneNumber { get; set; }
        }

    }
