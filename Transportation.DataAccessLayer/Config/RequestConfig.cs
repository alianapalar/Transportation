using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Config
{
    public class RequestConfig : IEntityTypeConfiguration<RequestType>
    {
        public void Configure(EntityTypeBuilder<RequestType> builder)
        {
            builder.HasData(
                new RequestType() { RequestTypeId = 1, RequestName = "Evden Taşıma",Image="/logistica-1.0.0/img/evdentasima.jpg" },
                new RequestType() { RequestTypeId=2,RequestName="Ağırlıkta Eşya Taşıma",Image = "/logistica-1.0.0/img/agirlikta-esya-tasima.jpg" },
                new RequestType() { RequestTypeId=3,RequestName="Ofis Taşıma",Image= "/logistica-1.0.0/img/ofis-tasima.jpg" },
                new RequestType() { RequestTypeId=4,RequestName="Büyük Hacim",Image= "/logistica-1.0.0/img/buyuk-hacim.jpeg" }
                );
        }
    }
}
