using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSBeheer.Model
{
    public partial class Account
    {
        [Key]
        public int Id { get; set; }
        [StringLength(32)]
        [Index(IsUnique =true)]
        public string Username { get; set; }
        [StringLength(64)]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
