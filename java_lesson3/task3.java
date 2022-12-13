package java_projects.homeworks.java_lesson3;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Random;

public class task3 {

    public static void main(String[] args) {
        // Задан целочисленный список ArrayList. Найти минимальное, максимальное и
        // среднее из этого списка.

        ArrayList<Integer> arr = new ArrayList<Integer>();

        arr.add(11);
        arr.add(45);
        arr.add(12);
        arr.add(32);
        arr.add(37);
        arr.add(47);

        int max = arr.get(0);
        int min = arr.get(0);
        double avg = 0;
        int res = 0;

        for (int item : arr) {
            if (item > max) {
                max = item;
            }
            if (item < min) {
                min = item;
            }
            res = res + item;
        }

        avg = res / arr.size();

        System.out.println(min);
        System.out.println(max);
        System.out.println(avg);
    }

}
