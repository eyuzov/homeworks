package homeworks.java_oop.homework1;

public class ToiletPaper extends Hihiena {
    protected int LayerCount;

    public ToiletPaper(String name, int price, int count, String measurement, int LayerCount) {
        super(name, price, count, measurement, LayerCount);
        this.LayerCount = LayerCount;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s Layer count: %d", this.name, this.price,
                this.count,
                this.measurement, this.LayerCount);
    }
}
