package homeworks.java_oop.homework1;

public class Nipple extends ForKids {

    public Nipple(String name, int price, int count, String measurement, int FromAge, String Hypoallergenic) {
        super(name, price, count, measurement, FromAge, Hypoallergenic);
        this.FromAge = FromAge;
        this.Hypoallergenic = Hypoallergenic;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s Min Age: %d Hypoallergenic: %s", this.name,
                this.price,
                this.count,
                this.measurement, this.FromAge, this.Hypoallergenic);
    }
}
