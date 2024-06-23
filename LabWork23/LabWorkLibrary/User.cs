namespace LabWorkLibrary
{
    /// <summary>
    /// Содержит данные о пользователе
    /// </summary>
    internal class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public Role role { get; set; }
    }
}