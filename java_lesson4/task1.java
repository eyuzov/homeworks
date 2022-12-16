package java_projects.homeworks.java_lesson4;

import java.util.LinkedList;

public class task1 {
    public static void main(String[] args) {

        LinkedList<Integer> myList = new LinkedList<Integer>();
        LinkedList<Integer> myListReverse = new LinkedList<Integer>();

        myList.add(1);
        myList.add(2);
        myList.add(3);
        myList.add(4);
        myList.add(5);
        myList.add(6);

        while (myList.size() > 0) {
            myListReverse.add(myList.pollLast());
        }
        System.out.println(myListReverse);
    }
}
