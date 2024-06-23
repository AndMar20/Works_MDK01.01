namespace Task1
{
    internal class Pet
    {
        //Task1
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
        //Task2
        public void Print()
        {
            Console.WriteLine($"Кличка: {_name} \nПорода: {_breed} \nВозраст: {_age} \n");
        }
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
