﻿namespace Task2
{
    internal class Pet : IComparable<Pet>
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

        public int CompareTo(Pet pet1)
        {
            Pet pet = pet1 as Pet;
            return Age.CompareTo(pet.Age);
        }
    }
}

