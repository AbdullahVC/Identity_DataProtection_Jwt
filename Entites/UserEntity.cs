namespace Identity_DataProtection_Jwt.Entites
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
