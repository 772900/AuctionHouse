using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuctionHouse.Models
{
    public class AuctionItem
    {

        public int AuctionItemId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ItemName { get; set; }    
        public string Description { get; set; }
        public decimal MinimumBid { get; set; }
        public int NumOfBids { get; set; }
    }
}