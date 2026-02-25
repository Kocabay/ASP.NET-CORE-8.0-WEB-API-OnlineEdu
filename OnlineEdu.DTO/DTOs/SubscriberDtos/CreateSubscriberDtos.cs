
using System.Security.AccessControl;

namespace OnlineEdu.DTO.DTOs.SubscriberDtos
{
    public class CreateSubscriberDtos
    {
        public string Email { get; set; }
        private bool IsActive { get => false; }

    }
}
