using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models {
    public class Repository {

        private DataContext _db = new DataContext();

        public IList<AuctionItem> GetAllItems() {
            return (from a in _db.AuctionItems orderby a.Id where a.MaximumBids > a.CurrentBids select a).ToList();
        }

        public void AddBidToItem(Bid bid, AuctionItem auctionItem) {
            if (bid.BidAmount > auctionItem.MinimumBid) {
                auctionItem.MinimumBid = bid.BidAmount;
                auctionItem.CurrentBids++;
                
                _db.SaveChanges();
            }
        }

        public void SaveAuctionItem(AuctionItem item) {
            AuctionItem newItem;
            if (item.Id != 0) {
                newItem = GetAuctionItemById(item.Id);
                newItem.Name = item.Name;
                newItem.Description = item.Description;
                newItem.CurrentBids = item.CurrentBids;
                newItem.MinimumBid = item.MinimumBid;
                newItem.MaximumBids = item.MaximumBids;
            } else {
                _db.AuctionItems.Add(item);
            }
            _db.SaveChanges();
        }

        public Bid CreateNewBid(int auctionId) {
            return new Bid {
                Name = "",
                BidAmount = 0m
            };
        }

        public Bid GetBidById(int id) {
            return (from b in _db.Bids where b.Id == id select b).FirstOrDefault();
        }

        public AuctionItem GetAuctionItemById(int id) {
            return (from a in _db.AuctionItems where a.Id == id select a).FirstOrDefault();
        }
    }
}