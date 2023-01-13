package homeworks.java_oop.homework1;

public class Milk extends Drinks {
    protected int fatPercentage;
    protected String expiration;

    public Milk(String name, int price, int count, String measurement, int volume, int fatPercentage,
            String expiration) {
        super(name, price, count, measurement);
        this.fatPercentage = fatPercentage;
        this.expiration = expiration;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Volume: %d Fat Percentage: %d Expiration: %s", this.name, this.price,
                this.volume, this.fatPercentage, this.expiration);
    }
}