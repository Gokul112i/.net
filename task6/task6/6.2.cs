using System;

class Gadget
{
    private string Brand;
    private string Model;
    private DateTime ReleaseDate;
    private double Price;

    public Gadget(string brand, string model, DateTime releaseDate, double price)
    {
        Brand = brand;
        Model = model;
        ReleaseDate = releaseDate;
        Price = price;
    }

    
    public int AgeInYears
    {
        get
        {
            int age = DateTime.Now.Year - ReleaseDate.Year;
            if (DateTime.Now.Date < ReleaseDate.Date.AddYears(age))
                age--;
            return age;
        }
    }

    public bool IsWarrantyValid
    {
        get
        {
            return DateTime.Now <= ReleaseDate.AddYears(2);
        }
    }

    public double DiscountedPrice
    {
        get
        {
            double discounted = Price;

            if (AgeInYears > 3)
                discounted *= 0.88; // 12% discount
            else if (AgeInYears > 1)
                discounted *= 0.95; // 5% discount

            return discounted;
        }
    }

    public string UniqueCode
    {
        get
        {
            string brandPart = Brand.Substring(0, 3).ToLower();
            string modelPart = Model.Substring(Model.Length - 2).ToLower();
            string yearPart = ReleaseDate.Year.ToString().Substring(2, 2);

            return brandPart + modelPart + yearPart;
        }
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"AgeInYears: {AgeInYears}");
        Console.WriteLine($"IsWarrantyValid: {IsWarrantyValid}");
        Console.WriteLine($"DiscountedPrice: {DiscountedPrice}");
        Console.WriteLine($"UniqueCode: {UniqueCode}");
    }
}

class Smartphone : Gadget
{
    public int RAM { get; set; }
    public int Storage { get; set; }
    public double CameraMP { get; set; }

    public Smartphone(string brand, string model, DateTime releaseDate, double price,
                      int ram, int storage, double cameraMP)
        : base(brand, model, releaseDate, price)
    {
        RAM = ram;
        Storage = storage;
        CameraMP = cameraMP;
    }

    public void DisplaySmartphoneDetails()
    {
        Console.WriteLine("---- Smartphone Details ----");
        DisplayBasicInfo();
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"Storage: {Storage} GB");
        Console.WriteLine($"Camera: {CameraMP} MP");
        Console.WriteLine();
    }
}

class Laptop : Gadget
{
    public int RAM { get; set; }
    public string Processor { get; set; }
    public double BatteryBackupHours { get; set; }

    public Laptop(string brand, string model, DateTime releaseDate, double price,
                  int ram, string processor, double backupHours)
        : base(brand, model, releaseDate, price)
    {
        RAM = ram;
        Processor = processor;
        BatteryBackupHours = backupHours;
    }

    public void DisplayLaptopDetails()
    {
        Console.WriteLine("---- Laptop Details ----");
        DisplayBasicInfo();
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"Battery Backup: {BatteryBackupHours} hrs");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Smartphone phone = new Smartphone(
            "Samsung", "Tab", new DateTime(2019, 5, 1), 30000,
            6, 128, 48.0);

        Laptop laptop = new Laptop(
            "Dell", "Inspiron", new DateTime(2021, 3, 15), 55000,
            16, "Intel i7", 8.5);

        phone.DisplaySmartphoneDetails();
        laptop.DisplayLaptopDetails();
    }
}
