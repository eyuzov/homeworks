package homeworks.java_oop.homework1;

public class task1 {

    public static void main(String[] args) {
        Tovar tovar1 = new Tovar("solt", 10, 1, "kg");
        System.out.println(tovar1);

        Food food1 = new Food("Bread", 10, 1, "kg", "15.01.2023");
        System.out.println(food1);

        Drinks drink1 = new Drinks("Kvas", 5, 1, "litres");
        System.out.println(drink1);

        Hihiena hihiena1 = new Hihiena("Napkin", 5, 1, "piece", 2);
        System.out.println(hihiena1);

        ForKids kids1 = new ForKids("botle", 50, 3, "piece", 1, "No");
        System.out.println(kids1);

        Milk milk1 = new Milk("Milk", 15, 1, "litres", 1, 3, "20.01.2023");
        System.out.println(milk1);

        Limonad limonad1 = new Limonad("Tarhun", 100, 1, "litres");
        System.out.println(limonad1);

        Bread bread1 = new Bread("White bread", 100, 1, "pieces", "White");
        System.out.println(bread1);

        Eggs eggs1 = new Eggs("Big Eggs", 100, 1, "pieces", 20);
        System.out.println(eggs1);

        Masks mask1 = new Masks("Masks", 100, 1, "pieces", 20);
        System.out.println(mask1);

        ToiletPaper paper1 = new ToiletPaper("Toilet Paper", 100, 1, "pieces", 20);
        System.out.println(paper1);

        Diapers diaper1 = new Diapers("Diapers", 100, 1, "pieces", 1, "No", 4, 1, 6, 7);
        System.out.println(diaper1);

        Nipple nipple1 = new Nipple("Nipple", 20, 1, "pieces", 0, "No");
        System.out.println(nipple1);

    }
}
