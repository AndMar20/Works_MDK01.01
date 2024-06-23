namespace Task1
{
    //Task1
    internal class Pet
    {
        private string _name;
        private string _breed;
        private int _age;

        public Pet() : this("Неизвестно", "Неизвестно", 0)
        {
        }

        public Pet(string name, string breed, int age)
        {
            _name = name;
            _breed = breed;
            _age = age;
        }

        //Task2
        public void Print()
        {
            Console.WriteLine($"Кличка: {_name} \nПорода: {_breed} \nВозраст: {_age} \n");
        }

        //Task3
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
    }
}
