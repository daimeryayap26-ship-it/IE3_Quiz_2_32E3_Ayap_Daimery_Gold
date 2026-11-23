using System.ComponentModel.DataAnnotations;

namespace IE3_Q2_32E3_Ayap_DaimeryGold.DTO.User
{
    public class AddUserRequest
    {
        [Required]
        public string? Id { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

    }

        public class EditUserRequest
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Mali buseng!")]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
