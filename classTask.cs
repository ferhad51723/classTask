// 1

class Human
{
    public string name;
    public string surname;
    public int age;
    public string gender;
    public string nationality;

    public Human(string name, string surname, int age, string gender, string nationality)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.gender = gender;
        this.nationality = nationality;
    }

    public void getFullName()
    {
        Console.WriteLine(name + " " + surname);
    }

    public void getBirthYear()
    {
        Console.WriteLine(2025 - age);
    }
}

// 2

class Device
{
    public string brand;
    public string model;
    public int screenSize;
    public int batteryLevel;
    public int price;
    public int salePrice;
    public int saleCount;

    public Device(string brand, string model, int screenSize, int batteryLevel, int price, int salePrice, int saleCount)
    {
        this.brand = brand;
        this.model = model;
        this.screenSize = screenSize;
        this.batteryLevel = batteryLevel;
        this.price = price;
        this.salePrice = salePrice;
        this.saleCount = saleCount;
    }

    public void CalculateProfit()
    {
        if(salePrice - price <= 0)
        {
            Console.WriteLine("Edilen ziyan" + (salePrice - price)*saleCount); 
        }
        else
        {
            Console.WriteLine((salePrice-price)*saleCount);
        }
    }

    public int DisplayBatteryLevel()
    {
        return batteryLevel;
    }

    public string DeviceDetails()
    {
        return $"Brand: {brand}, Model: {model}, Screen Size: {screenSize}";
    }


    public void FilterByPrice(Device[] array, int price)
    {
        foreach (Device product in array)
        {
            if (product.price > price)
            {
                Console.WriteLine($"{product.brand} {product.model} - Price: {product.price}");
            }
        }
    }

    public static int FilterByName(Device[] array, string model)
    {
        int count = 0;
        foreach (Device product in array)
        {
            if (product.model == model)
            {
                count++;
            }
        }
        return count;
    }

}

class Phone : Device
{
    public bool isSmart;

    public Phone(string brand, string model, int screenSize, int batteryLevel, int price, int salePrice, int saleCount, bool isSmart)
        : base(brand, model, screenSize, batteryLevel, price, salePrice, saleCount)
    {
        this.isSmart = isSmart;
    }

}

class Laptop:Device
{
    public bool isRGBkeyboard;

    public Laptop(string brand, string model, int screenSize, int batteryLevel, int price, int salePrice, int saleCount, bool isRGBkeyboard)
        : base(brand, model, screenSize, batteryLevel, price, salePrice, saleCount)
    {
        this.isRGBkeyboard = isRGBkeyboard;
    }
}
