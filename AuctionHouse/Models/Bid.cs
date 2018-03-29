using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuctionHouse.Models
{
    public class Bid
    {
        public int BidId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public decimal BidAmount { get; set; }
        public int AuctionItemId { get; set; }
        [ForeignKey("AuctionItemId")]
        public virtual AuctionItem AuctionItem { get; set; }

    }
}