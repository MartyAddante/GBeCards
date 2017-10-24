using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class CardsModel
    {
        public string Message { get; set; }
        public string ImageName { get; set; }
        public Guid ImageId { get; set; }
        public string BackgroundName { get; set; }
        public Guid BackgroundId { get; set; }
        public string FontName { get; set; }
        public Guid FontId { get; set; }
    }
}