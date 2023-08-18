using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnipiGuide.Models
{
    internal class Review
    {
        int stars; /* 1-5 */
        string comment; /* can be null */
        int reviewId;

        public int ReviewId { get; set; }

        public int Stars { get; set; }
        public string Comment { get { return comment; } set { comment = value; } }
    }
}
