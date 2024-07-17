namespace Records
{
    
    public record UserDto(int Id, string Username, string Email);

    public class UserDtoClass
    {
        public int Id { get; init; }
        public string Username { get; init; }
        public string Email { get; init; }

        public UserDtoClass(int id, string username, string email)
        {
            Id = id;
            Username = username;
            Email = email;
        }
    }
}
