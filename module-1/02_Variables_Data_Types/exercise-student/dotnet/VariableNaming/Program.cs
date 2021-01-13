namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */

            int initialNumberOfRaccoons = 3;
            int racoonsThatLeft = 2;
            int remainingRaccoons = initialNumberOfRaccoons - racoonsThatLeft;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int flowers = 5;
            int bees = 3;
            int beesComparedToFlowers = flowers - bees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int lonelyPidgeon = 1;
            int anotherPidgeon = 1;
            int totalLonelyPidgeons = lonelyPidgeon + anotherPidgeon;

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            int originalOwls = 3;
            int newOwls = 2;
            int totalOwls = originalOwls + newOwls;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int originalBeavers = 2;
            int swimmingBeavers = 1;
            int homeBeavers = originalBeavers - swimmingBeavers;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int treeToucans = 2;
            int newToucans = 1;
            int totalToucans = treeToucans + newToucans;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int totalSquirrels = 4;
            int totalNuts = 2;
            int overflowSquirrels = totalSquirrels - totalNuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            decimal quarter = 0.25M;
            decimal dime = 0.10M;
            decimal nickel = 0.05M;
            decimal foundMoney = quarter + dime + nickel + nickel;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int mrsBrierClassMuffins = 18;
            int mrsMacadamsClassMuffins = 20;
            int mrsFlanneryClassMuffins = 17;
            int totalMuffins = mrsBrierClassMuffins + mrsMacadamsClassMuffins + mrsFlanneryClassMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            decimal yoyo = 0.24M;
            decimal whistle = 0.14M;
            decimal toysTotalCost = yoyo + whistle;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */

            int largeMarshmallow = 8;
            int miniMarshmallow = 10;
            int totalMarshmallows = largeMarshmallow + miniMarshmallow;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int mrsHiltsHouseSnow = 29;
            int brecknockSchoolSnow = 17;
            int differenceInSnow = mrsHiltsHouseSnow - brecknockSchoolSnow;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            decimal mrsHiltMoney = 10M;
            decimal toyTruck = 3M;
            decimal pencilCase = 2M;
            decimal remainingMoney = mrsHiltMoney - toyTruck - pencilCase;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int joshInitialMarbles = 16;
            int lostMarbles = 7;
            int joshTotalMarbles = joshInitialMarbles - lostMarbles;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int fullSeashellCollection = 25;
            int meganSeashells = 19;
            int seashellsNeeded = fullSeashellCollection - meganSeashells;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int currentBookShelf = 38;
            int newBooks = 10;
            int totalBooks = currentBookShelf + newBooks;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int numberOfBees = 8;
            int numberofBeeLegs = 6;
            int totalBeeLegs = numberOfBees * numberofBeeLegs;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            decimal iceCream = 0.99M;
            decimal twoIceCreams = iceCream * 2;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int completeBorder = 125;
            int currentRocks = 64;
            int neededToComplete = completeBorder - currentRocks;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int initialMarbles = 38;
            int lostHiltMarbles = 15;
            int currentMarbles = initialMarbles - lostHiltMarbles;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int milesDriven = 32;
            int totalMiles = 78;
            int milesLeft = totalMiles - milesDriven;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */

            int shovelingSaturdayMorning = 90;
            int shovelingSaturdayAfternoon = 45;
            int totalShoveling = shovelingSaturdayMorning + shovelingSaturdayAfternoon;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            decimal hotDogCost = 0.50M;
            int purchasedHotDogs = 6;
            decimal totalCost = purchasedHotDogs * hotDogCost;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            decimal pencilCost = .07M;
            decimal totalMoney = 0.50M;
            int pencilToBuy = (int)(totalMoney / pencilCost);

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            decimal moneyGiven = 1.00M;
            decimal candyCost = 0.54M;
            decimal change = moneyGiven - candyCost;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int startingTrees = 13;
            int treesPlanted = 12;
            int totalTrees = startingTrees + treesPlanted;

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int daysUntilGrandma = 2;
            int hoursPerDay = 24;
            int hoursUntilGrandma = daysUntilGrandma * hoursPerDay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int cousins = 4;
            int gumPerCousin = 5;
            int gumNeeded = cousins * gumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal startingMoney = 3.00M;
            decimal candyBarCost = 1.00M;
            decimal moneyLeftOver = startingMoney - candyBarCost;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int totalBoats = 5;
            int totalPeoplePerBoat = 3;
            int totalPeople = totalBoats * totalPeoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int startingLegos = 380;
            int lostLegos = 57;
            int finalLegos = startingLegos - lostLegos;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int muffinsNeeded = 83;
            int startingMuffins = 35;
            int missingMuffins = muffinsNeeded - startingMuffins;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willyCrayons = 1400;
            int lucyCrayon = 290;
            int crayonDifference = willyCrayons - lucyCrayon;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickersPerPage = 10;
            int pages = 22;
            int stickers = stickersPerPage * pages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            double cupcakes = 96;
            double children = 8;
            double cupcakesPerChild = cupcakes / children;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int cookies = 47;
            int jars = 6;
            int leftoverCookies = cookies % jars;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int croissants = 59;
            int neighbors = 8;
            int leftoverCroissants = croissants % neighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int oatmealCookies = 276;
            int cookiesPerTray = 12;
            int traysNeeded = oatmealCookies / cookiesPerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int pretzels = 480;
            int pretzelsPerServing = 12;
            int totalPretzels = pretzels / pretzelsPerServing;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int lemonCakes = 53;
            int cakesPerBox = 3;
            int cakesLeft = 2;
            int boxesGivenAway = (lemonCakes - cakesLeft) / cakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int carrotSticks = 74;
            int people = 12;
            int carrotsUneaten = carrotSticks % people;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int teddyBears = 98;
            int teddyPerShelf = 7;
            int shelvesFilled = teddyBears / teddyPerShelf;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int pictures = 480;
            int picturesPerAlbum = 20;
            int totalAlbums = pictures / picturesPerAlbum;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int totalCards = 94;
            int cardsPerBox = 8;
            int leftoverCards = totalCards % cardsPerBox;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int books = 210;
            int bookshelves = 10;
            int booksPerShelf = books / bookshelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            double totalCroissants = 17;
            double numberOfGuests = 7;
            double croissantsPerGuest = totalCroissants / numberOfGuests;

            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */

            double wallSize = 12 * 14;
            double billSqftPerHour = wallSize / 2.15;
            double jillSqftPerHour = wallSize / 1.90;
            double totalSqftPerHour = billSqftPerHour + jillSqftPerHour;
            double timeToComplete = 5 * wallSize / totalSqftPerHour;

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */

            string firstName = "Grace";
            string middleInitial = "B";
            string lastName = "Hopper";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";

            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */

            double distance = 800;
            double amountTravelled = 537;
            int percentComplete = (int)(amountTravelled / distance * 100);
        }
    }
}
