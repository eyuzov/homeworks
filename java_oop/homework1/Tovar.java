package homeworks.java_oop.homework1;

public class Tovar {
    protected String name;
    protected int price;
    protected int count;
    protected String measurement;

    public Tovar(String name, int price, int count, String measurement) {
        this.name = name;
        this.price = price;
        this.count = count;
        this.measurement = measurement;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s", this.name, this.price, this.count,
                this.measurement);
    }

}
