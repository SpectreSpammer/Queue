using System.ComponentModel.DataAnnotations;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data
{
    public class QueueEmployeeSettings
    {
        [Key]
        public int QueueGuid { get; set; }

        public string QueueName { get; set; }

        public int isSharedQueue { get; set; }
    }
}
