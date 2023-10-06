class Car
{
    private int oilCount;
    public Car(int initialOilCount)
    {
        oilCount = initialOilCount;
    }
    public void Move()
    {
        if (oilCount - 100 > 0)
        {
            Console.WriteLine("Автомобиль едет.");
            oilCount -= 100;
        }
        else
        {
            Console.WriteLine("Недостаточно бензина для движения.");
        }
    }
    public void Refill(int oilCount)
    {
        this.oilCount += oilCount;
        Console.WriteLine("Автомобиль заправлен. Текущий уровень бензина: " + this.oilCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(500);
        car.Move(); 
        car.Move();
        car.Refill(200); 
        car.Move();
        car.Move();
        car.Move(); 
    }
}
