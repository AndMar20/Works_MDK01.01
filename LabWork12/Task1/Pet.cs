public struct Pet
{
    private string _name;
    private string _breed;
    private int _age;
    public AnimalType animalType;

    #region Свойства
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length < 1)
                throw new ArgumentException(nameof(value), "Длина имени не может быть меньше одного символа");
            _name = value;
        }
    }
    public string Breed
    {
        get => _breed;
        set
        {
            if (value.Length < 1)
                throw new ArgumentException(nameof(value), "Название породы не может быть меньше одного символа");
            _breed = value;
        }
    }
    public int Age
    {
        get => _age;
        set
        {
            if (_age < 0)
                throw new ArgumentException(nameof(value), "Возраст не может быть меньше нуля");
            _age = value;
        }
    }
    #endregion

    public Pet() : this("Неизвестно", "Неизвестно", 0) { }

    public Pet(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
        //animalType = AnimalType.Cat;
        animalType = 0;
    }
    public void Print()
    {
        Console.WriteLine($"Кличка: {Name} , порода: {Breed}, возраст: {Age}, вид: {animalType}");
    }
}
