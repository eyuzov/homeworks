package homeworks.java_oop.homework1;

public class Masks extends Hihiena {
    protected int countInPack;

    public Masks(String name, int price, int count, String measurement, int countInPack) {
        super(name, price, count, measurement, countInPack);
        this.countInPack = countInPack;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s count In Pack: %d", this.name, this.price,
                this.count,
                this.measurement, this.countInPack);
    }
}
