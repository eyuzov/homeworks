package homeworks.java_oop.homework1;

public class Food extends Tovar {
    protected String expiration;

    public Food(String name, int price, int count, String measurement, String expiration) {
        super(name, price, count, measurement);
        this.expiration = expiration;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s Expiration: %s", this.name, this.price,
                this.count,
                this.measurement, this.expiration);
    }

}
