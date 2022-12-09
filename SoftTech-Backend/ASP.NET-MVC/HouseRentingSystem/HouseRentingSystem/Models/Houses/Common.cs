namespace HouseRentingSystem.Models.Houses
{
    public class Common
    {
        public static IEnumerable<HouseDetailsViewModel> GetHouses()
        {
            return new List<HouseDetailsViewModel>()
            {
                new HouseDetailsViewModel
                {
                    Title = "House Maria",
                    Address = "Sofia, Bulgaria",
                    ImageUrl = "https://static.bgstay.com/bgstay.com/images/photos/45/45882/new/pic_45882_6.jpg"
                },
                new HouseDetailsViewModel
                {
                    Title = "House Emil",
                    Address = "Burgas, Bulgaria",
                    ImageUrl = "https://photo.barnes-international.com/annonces/bms/181/xl/733272875e7030f2ef7eb6.19188976_7dbf53b483_1920.jpg"
                },
                new HouseDetailsViewModel
                {
                    Title = "Family House",
                    Address = "Varna, Bulgaria",
                    ImageUrl = "https://media1.ispdd.com/projects/big/proekt-za-kashta-Varna-R5rH4-68627028273658452.jpg"
                },
            };
        }
    }
}
