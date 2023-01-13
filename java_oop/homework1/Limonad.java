package homeworks.java_oop.homework1;

public class Limonad extends Drinks {

    public Limonad(String name, int price, int count, String measurement) {
        super(name, price, count, measurement);

    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s", this.name, this.price,
                this.count,
                this.measurement);
    }
}
