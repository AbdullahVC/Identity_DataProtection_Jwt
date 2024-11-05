namespace Identity_DataProtection_Jwt.Entites
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            createdDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
