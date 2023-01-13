package homeworks.java_oop.homework1;

public class Hihiena extends Tovar {
    protected int countInPack;

    public Hihiena(String name, int price, int count, String measurement, int countInPack) {
        super(name, price, count, measurement);
        this.countInPack = countInPack;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s count In Pack: %d", this.name, this.price,
                this.count,
                this.measurement, this.countInPack);
    }
}
