using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
    public class CompositeWithIteratorExample
    {
        public static void Run()
        {
            Menu shakeMenu = new Menu("Cook Out Shake Menu", "Shake Flavors");
            shakeMenu.Add(new MenuItem("Vanilla", "Vanilla", 3.99, true));
            shakeMenu.Add(new MenuItem("Reese's", "Mini Reese's Peanut Butter Cups", 3.99, true));
            shakeMenu.Add(new MenuItem("Pineapple", "Canned Pineapple", 3.99, true));
            shakeMenu.Add(new MenuItem("Watermelon", "Fresh Watermelon (July & August only)", 3.99, true));

            Menu cookOutMenu = new Menu("Cook Out Menu", "Full cookout menu");
            cookOutMenu.Add(new MenuItem("Cook Out Style Burger", "Classic", 2.99));
            cookOutMenu.Add(new MenuItem("Corn Dog", "Hot Dog on a stick, coated in corn breading and fried", 1.99));
            cookOutMenu.Add(new MenuItem("Cook Out Tray", "Entree, Two Sides, and a shake", 4.99));
            cookOutMenu.Add(new MenuItem("Hush puppies", "hot and fried", .99, true));
            cookOutMenu.Add(shakeMenu);

            Menu bojanglesMenu = new Menu("Bojangles Menu", "Chicken and Biscuits");
            bojanglesMenu.Add(new MenuItem("Sweet Tea", "Sugar with tea flavoring", .99, true));
            bojanglesMenu.Add(new MenuItem("Butter Biscuit", "Biscuit sliced and buttered", .99, true));
            bojanglesMenu.Add(new MenuItem("Bacon, Egg, and Cheese Biscuit", "2 strips of bacon, american cheese, and an egg inside a biscuit", 2.99, false));
            bojanglesMenu.Add(new MenuItem("4 pc Supremes Meal", "4 Chicken Supremes, Cajun fries, and a biscuit w/ tea", 5.99, false));

            Menu waffleHouseMenu = new Menu("Waffle House Menu", "24 hour diner so reliable it informs FEMA decisions");
            waffleHouseMenu.Add(new MenuItem("All Star Breakfast", "Waffle, Scrambled Eggs, Hashbrowns, Bacon", 6.99, false));
            waffleHouseMenu.Add(new MenuItem("Smothered and Covered Hashbrowns", "Hashbrowns with cheese, onions, and delicious grease", 1.99, true));
            waffleHouseMenu.Add(new MenuItem("Reese's Pieces Waffle", "A waffle with Reese's Pieces in it -- not dessert", 1.99, true));

            Menu allmenus = new Menu("Super Restuarant Menu", "One restuarant to rule them all");
            allmenus.Add(cookOutMenu);
            allmenus.Add(bojanglesMenu);
            allmenus.Add(waffleHouseMenu);

            SuperRestaurantServer server = new SuperRestaurantServer(allmenus);

            server.PrintVegetarianMenu();
        }
    }
}
