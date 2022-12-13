package java_projects.homeworks.java_lesson3;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class task2 {

    public static void main(String[] args) {
        // Пусть дан произвольный список целых чисел, удалить из него четные числа

        List<Integer> arr = new ArrayList<Integer>();

        arr.add(11);
        arr.add(45);
        arr.add(12);
        arr.add(32);
        arr.add(37);

        List<Integer> newArr = new ArrayList<Integer>();

        System.out.println(arr.toString());

        for (int item : arr) {
            if (item % 2 == 0) {
                newArr.add(item);
            }
        }

        arr.removeAll(newArr);

        System.out.println(arr.toString());
    }
}