package homeworks.java_oop.homework1;

public class Eggs extends Food {
    protected int pieceInPack;

    public Eggs(String name, int price, int count, String measurement, int pieceInPack) {
        super(name, price, count, measurement, measurement);
        this.pieceInPack = pieceInPack;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %d Count: %d Measurement: %s flourType: %s", this.name, this.price,
                this.count,
                this.measurement, this.pieceInPack);
    }
}
