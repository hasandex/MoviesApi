namespace MoviesApi.Dtos
{
    public class NewUserDto
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string? phoneNumber { get; set; }
    }
}
