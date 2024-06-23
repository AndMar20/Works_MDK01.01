namespace Task1
{
    internal class Pet
    {
        private string _name;
        private string _breed;
        private int _age;

        #region Констуркторы
        public Pet() : this("Неизвестно", "Неизвестно", 0)
        {
        }

        public Pet(string name, string breed, int age)
        {
            _name = name;
            _breed = breed;
            _age = age;
        }
        #endregion

        #region Методы
        public void Print()
        {
            Console.WriteLine($"Кличка: {Name} \nПорода: {Breed} \nВозраст: {Age} \n");
        }
        #endregion

        #region Перегрузки операторов
        public static Pet operator ++(Pet pet) => new Pet
        {
            Name = pet.Name,
            Breed = pet.Breed,
            Age = pet.Age + 1
        };

        public static Pet operator +(Pet pet1, Pet pet2) => new Pet
        {
            Name = pet1.Name,
            Breed = pet1.Breed,
            Age = pet1.Age + pet2.Age
        };

        public static bool operator ==(Pet pet1, Pet pet2) => (pet1.Name == pet2.Name && pet1.Breed == pet2.Breed && pet1.Age == pet2.Age);

        public static bool operator !=(Pet pet1, Pet pet2) => (pet1.Name != pet2.Name || pet1.Breed != pet2.Breed || pet1.Age != pet2.Age);

        public static bool operator true(Pet pet) => (pet.Age >= 0);

        public static bool operator false(Pet pet) => (pet.Age < 0);
        #endregion

        #region Индексаторы
        public object? this[string index]
        {
            get
            {
                return index switch
                {
                    "Кличка" => _name,
                    "Порода" => _breed,
                    _ => null
                };
            }
        }

        public char this[int index]
        {
            get
            {
                if (index <= Name.Length && index >= 0)
                    return Name[index];
                return '\0';
            }
        }
        #endregion

        #region Свойства
        public string Name
        {
            get => _name;
            set
            {
                value = _name.Trim();
                if (_name != value && value != "")
                    _name = value;
            }
        }
        public string Breed
        {
            get => _breed;
            set
            {
                value = _breed.Trim();
                if (_breed != value && value != "")
                    _breed = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (_age >= 0)
                    _age = value;
            }
        }
        #endregion
    }
}
