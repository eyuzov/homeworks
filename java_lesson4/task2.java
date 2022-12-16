package java_projects.homeworks.java_lesson4;

import java.util.LinkedList;
import java.util.Queue;

public class task2 {

    public static void enqueue(Queue q, int elem) {
        q.add(elem);
    }

    public static void dequeue(Queue q) {
        System.out.println(q.remove());
    }

    public static void first(Queue q) {
        System.out.println(q.element());
    }

    public static void main(String[] args) {

        Queue myQueue = new LinkedList<>();
        myQueue.add(1);
        myQueue.add(2);
        myQueue.add(3);
        myQueue.add(4);
        myQueue.add(5);
        myQueue.add(6);

        System.out.println(myQueue);
        first(myQueue);
        System.out.println(myQueue);
        dequeue(myQueue);
        System.out.println(myQueue);
        enqueue(myQueue, 9);
        System.out.println(myQueue);
    }
}
