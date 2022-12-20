package java_projects.homeworks.java_lesson5;

import java.util.HashMap;

/**
 * task1
 */
public class task1 {

    public static void main(String[] args) {
        // Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1
        // человек может иметь несколько телефонов.
        HashMap<Integer, String> phoneBook = new HashMap<>();

        phoneBook.put(123456789, "Ivanov Ivan");
        phoneBook.put(123456780, "Petrov Petr");
        phoneBook.put(123456781, "Sidorov Andrey");
        phoneBook.put(123456782, "Petrov Ivan");
        phoneBook.put(123456783, "Ivanov Petr");
        phoneBook.put(123456784, "Petrov Ivan");
        phoneBook.put(123456785, "Sidorov Ivan");
        phoneBook.put(123456786, "Petrov Petr");
        phoneBook.put(123456787, "Ivanov Ivan");

        System.out.println(phoneBook);

    }
}