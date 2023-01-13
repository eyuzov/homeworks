package homeworks.java_oop.homework1;

public class Diapers extends ForKids {
    protected int size;
    protected int minWeight;
    protected int maxWeight;
    protected int type;

    public Diapers(String name, int price, int count, String measurement, int FromAge, String Hypoallergenic, int size,
            int minWeight, int maxWeight, int type) {
        super(name, price, count, measurement, FromAge, Hypoallergenic);
        this.size = size;
        this.minWeight = minWeight;
        this.maxWeight = maxWeight;
        this.type = type;
    }

    @Override
    public String toString() {
        return String.format(
                "Name: %s Price: %d Count: %d Measurement: %s Min Age: %d Hypoallergenic: %s Size %d Min Weight %d Max Weight %d Type %d",
                this.name,
                this.price,
                this.count,
                this.measurement, this.FromAge, this.Hypoallergenic, this.size, this.minWeight, this.maxWeight,
                this.type);
    }
}
