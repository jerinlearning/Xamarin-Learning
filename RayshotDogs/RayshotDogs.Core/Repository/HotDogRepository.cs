using RayshotDogs.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayshotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupId=1,Title="Meat Lovers",ImagePath="",HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name="All American Regular Hot Dog",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name="Haute Dog with German Sausage",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name="Extra Long Hot Dog",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    }
                }
            },
             new HotDogGroup()
            {
                HotDogGroupId=2,Title="Favorites",ImagePath="",HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name="All American Regular Hot Dog",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name="Haute Dog with German Sausage",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name="Extra Long Hot Dog",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    }
                }
            },
            new HotDogGroup()
            {
                HotDogGroupId=3,Title="Veggie Lovers",ImagePath="",HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name="All American Regular Hot Dog",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name="Haute Dog with German Sausage",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name="Extra Long Hot Dog",
                        ShortDescription="The best there is on this planet",
                        Description="Manchego smelly cheese danish fontina. Hard cheese cow goat red leicester pecorino macaroni cheese cheesecake gouda. Ricotta fromage cheese and biscuits stinking bishop halloumi monterey jack cheese strings goat. Pecorino babybel pecorino jarlsberg cow say cheese cottage cheese.",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime= 10,
                        Price=8,
                        IsFavorite=true,
                        Ingredients=new List<string>() { "Regular bun:", "Sausage","Ketchup" }
                    }
                }
            }
        };

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                 from hotDogGroup in hotDogGroups
                 from hotDog in hotDogGroup.HotDogs

                 select hotDog;
            return hotDogs.ToList<HotDog>();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == hotDogId
                select hotDog;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            var group = hotDogGroups.Where(h => h.HotDogGroupId == hotDogGroupId).FirstOrDefault();

            if (group != null)
            {
                return group.HotDogs;
            }
            return null;
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.IsFavorite
                select hotDog;

            return hotDogs.ToList<HotDog>();
        }
    }
}