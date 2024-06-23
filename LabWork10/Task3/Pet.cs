namespace Task3
{
    internal class Pet : IEquatable<Pet>
    {
        private string _name;
        private string _breed;
        private int _age;

        #region Констуркторы
        public Pet() : this("Неизвестно", "Неизвестно", 0) { }

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
                    throw new ArgumentException(nameof(value), "Длина породы не может быть меньше одного символа");
                _breed = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (_age < 0)
                    throw new ArgumentException(nameof(value), "Возраст  не может быть меньше нуля");
                _age = value;
            }
        }
        #endregion

        public bool Equals(Pet pet)
        {
            if (Name == pet.Name && Breed == pet.Breed && Age == pet.Age)
                return true;
            return false;
        }
    }
}
