using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SaleManager : ISaleService
    {
        public void SellGame(User user, Game game)
        {
            if (game.Campaign != null)
            {
                decimal discountAmount = (game.UnitPrice * game.Campaign.DiscountRate) / 100;
                game.UnitPrice -= discountAmount;
                user.PurchasedGames.Add(game);
                Console.WriteLine(user.Name + " adlı kullanıcı " + game.Name + " adlı oyunu " + game.UnitPrice + " TL Fiyat ile satın aldı");


            }
            else
            {
                user.PurchasedGames.Add(game);
                Console.WriteLine(user.Name + " adlı kullanıcı " + game.Name + " adlı oyunu " + game.UnitPrice + " TL Fiyat ile satın aldı");
            }


        }
    }
}
