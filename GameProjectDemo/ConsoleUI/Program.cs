using GameProjectDemo;
using Entities.Concretes;
using System.Reflection.Metadata;
using Business.Concretes;


namespace GameProjectDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Id = 1;
            user1.IdentityNo = "12345678900";
            user1.Name = "Hasan Can";
            user1.BirthYear = 1999;

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Kara Kasım";
            campaign1.DiscountRate = 25;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.Name = "Efsane Kasım 2";
            campaign2.DiscountRate = 50;

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Yarış";
            game1.UnitPrice = 250;
            game1.Campaign = campaign1;

            Game game2 = new Game();
            game2.Id = 1;
            game2.Name = "Aksiyon";
            game2.UnitPrice = 200;
            game2.Campaign = campaign2;

            Game game3 = new Game();
            game3.Id = 1;
            game3.Name = "Futbol";
            game3.UnitPrice = 400;

            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Add(user1);
            userManager.Update (user1);
            userManager.Delete(user1);

            Console.WriteLine("---------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            campaignManager.Add(campaign2);

            Console.WriteLine("---------------");

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update (game1);
            gameManager.Delete(game1);

            gameManager.Add(game2);


            Console.WriteLine("---------------");

            SaleManager saleManager = new SaleManager();
            saleManager.SellGame(user1, game1);
            saleManager.SellGame(user1, game2);
            saleManager.SellGame(user1, game3);




        }
    }
}
