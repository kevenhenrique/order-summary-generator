using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_summary_generator.Entities.Enum
{
   enum OrderStatus : int
    {
        PendignPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered =3,
    }
}
