using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitirme.Eticaret.Core.Model.Entity
{
    public class Basket:EntityBase
    {
        public int UserID { get; set; }

        public int ProductID { get; set; }

        public Product Product { get; set; } //Sepetteki ürünün diğer özelliklerini görmek için ilişki kuruyoruz...

        public int Quantity { get; set; }


    }
}
