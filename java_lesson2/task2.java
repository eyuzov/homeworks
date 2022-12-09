package java_projects.homeworks.java_lesson2;

import java.io.FileWriter;
import java.io.IOException;

public class task2 {

    static void logging(int[] arr) throws IOException {
        FileWriter fw = new FileWriter("log.txt", true);
        String res = "";
        for (int i = 0; i < arr.length; i++) {
            res = res + arr[i] + " ";
        }
        res = res + "\n";
        fw.write(res);
        fw.flush();
        fw.close();
    }

    public static void main(String[] args) throws IOException {
        int[] sortArr = { 12, 6, 4, 1, 15, 10 };
        for (int i = 0; i < sortArr.length - 1; i++) {
            for (int j = 0; j < sortArr.length - i - 1; j++) {
                if (sortArr[j + 1] < sortArr[j]) {
                    int swap = sortArr[j];
                    sortArr[j] = sortArr[j + 1];
                    sortArr[j + 1] = swap;
                    logging(sortArr);
                }
            }
        }

        for (int i = 0; i < sortArr.length; i++) {
            System.out.print(sortArr[i] + " ");
        }

    }
}
