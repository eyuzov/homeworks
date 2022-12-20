package java_projects.homeworks.java_lesson5;

import java.util.ArrayList;
import java.util.HashMap;

public class task2 {
    public static void main(String[] args) {
        // Пусть дан список сотрудников:Иван Иванов ( и остальные, полный текст дз будет
        // на платформе)
        // Написать программу, которая найдет и выведет повторяющиеся имена с
        // количеством повторений. Отсортировать по убыванию популярности.
        ArrayList<String> arr = new ArrayList<>();
        arr.add("Ivanov Ivan");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Petrov Andrey");
        arr.add("Ivanov Petr");
        arr.add("Ivanov Ivan");
        arr.add("Ivanov Ivan");

        ArrayList<String> arrCopy = (ArrayList<String>) arr.clone();

        int count = 0;
        HashMap<Integer, String> list = new HashMap<>();
        for (int i = 0; i < arr.size(); i++) {
            count = 0;
            for (int j = 0; j < arrCopy.size(); j++) {
                if (arr.get(i).equals(arrCopy.get(j))) {
                    count++;
                }
            }
            if (count > 1) {
                list.put(count, arr.get(i));
            }

        }
        System.out.println(list);
    }
}
