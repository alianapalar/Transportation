using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
        public ICollection<Review> GivenReviews { get; set; }
        public string? Image { get; set; }

    }
}
