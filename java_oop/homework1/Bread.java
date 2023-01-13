package homeworks.java_oop.homework1;

public class Bread extends Food {
    protected String flourType;

    public Bread(String name, int price, int count, String measurement, String flourType) {
        super(name, price, count, measurement, flourType);
        this.flourType = flourType;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s flourType: %s", this.name, this.price,
                this.count,
                this.measurement, this.flourType);
    }
}
