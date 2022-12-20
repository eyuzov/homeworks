package java_projects.homeworks.java_lesson5;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.stream.Collectors;
import java.util.*;
// import java.util.TreeMap;

public class task2 {
    public static void main(String[] args) {
        // Пусть дан список сотрудников:Иван Иванов ( и остальные, полный текст дз будет
        // на платформе)
        // Написать программу, которая найдет и выведет повторяющиеся имена с
        // количеством повторений. Отсортировать по убыванию популярности.
        ArrayList<String> arr = new ArrayList<>();

        arr.add("Ivanov Ivan");
        arr.add("Petrov Andrey");
        arr.add("Petrov Andrey");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Petrov Petr");
        arr.add("Ivanov Petr");
        arr.add("Ivanov Petr");
        arr.add("Ivanov Ivan");

        ArrayList<String> arrCopy = (ArrayList<String>) arr.clone();

        int count = 0;

        HashMap<String, Integer> list = new HashMap<>();

        for (int i = 0; i < arr.size(); i++) {
            count = 0;
            for (int j = 0; j < arrCopy.size(); j++) {
                if (arr.get(i).equals(arrCopy.get(j))) {
                    count++;
                }

            }
            if (count > 1) {
                list.put(arr.get(i), count);
                count = 0;
            }

        }
        System.out.println(list);
        Map<String, Integer> sortedList = list.entrySet().stream()
                .sorted(Comparator.comparingInt(e -> -e.getValue()))
                .collect(Collectors.toMap(
                        Map.Entry::getKey,
                        Map.Entry::getValue,
                        (a, b) -> {
                            throw new AssertionError();
                        },
                        LinkedHashMap::new));

        System.out.println(sortedList);
    }
}
