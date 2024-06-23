namespace Task1
{
    internal class Pet
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
        public override string ToString() => $"Кличка: {Name} \nПорода: {Breed} \nВозраст: {Age} \n";

        public override bool Equals(object? obj)
        {
            Pet pet = obj as Pet;
            return Name == pet.Name 
                && Breed == pet.Breed 
                && Age == pet.Age;
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
