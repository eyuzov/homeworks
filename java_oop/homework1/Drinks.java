package homeworks.java_oop.homework1;

public class Drinks extends Tovar {
    protected int volume;

    public Drinks(String name, int price, int count, String measurement) {
        super(name, price, count, measurement);
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s Volume: %d", this.name, this.price,
                this.count,
                this.measurement, this.volume);
    }
}
