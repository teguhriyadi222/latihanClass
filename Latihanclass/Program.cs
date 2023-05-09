class manusia {

    public string? name;

    public int? age;
    private int? _salary;

    public manusia(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public manusia(string name, int age, int salary) {
        this.name = name;
        this.age = age;
        this._salary = salary;
    }

    public void SetSalary(int _salary) {
        this._salary = _salary * 1000;
    }
    public  string GetSalary() {
            
                if (_salary < 10000 ) {
                    return("gajimu sitek");
                }
                else {
                    return("gajimu akeh");
                }
            
        }
}

static class program {

    static void Main() {

        manusia manusia2 = new manusia("teguh", 18, 0);
        manusia2.SetSalary(1);
        Console.WriteLine($"nama manusianya adalah " + manusia2.name + "\ndan umurnya adalah " + manusia2.age);
        Console.WriteLine("gaji teguh adalah :" + manusia2.GetSalary());

        Console.WriteLine("Masukkan nama manusia: ");
        string name = Console.ReadLine();
        Console.WriteLine("Masukkan umur manusia: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukkan gaji manusia: ");
        int salary = int.Parse(Console.ReadLine());

        manusia manusia3 = new manusia(name, age,salary);
        Console.WriteLine("nama manusianya adalah " + manusia3.name + "\ndan umurnya adalah " + manusia3.age);
        Console.WriteLine("gaji " + manusia3.name + " adalah:" + manusia3.GetSalary());
    }
}