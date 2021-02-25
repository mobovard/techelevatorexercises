using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("/")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("auctions")]
        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0d)
        {
            if (title_like == "" && currentBid_lte == 0d)
            {
                return dao.List();
            }
            else if (title_like == "")
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else if (currentBid_lte == 0d)
            {
                return dao.SearchByTitle(title_like);
            }
            else
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
        }

        [HttpGet("auctions/{id}")]
        public Auction GetAuction(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }

            return null;
        }

        [HttpPost("auctions")]
        public Auction AddAuction(Auction auction)
        {
            return dao.Create(auction);
        }
    }
}
