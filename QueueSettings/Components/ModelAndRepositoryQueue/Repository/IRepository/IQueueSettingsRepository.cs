using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Models;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository.IRepository
{
    public interface IQueueSettingsRepository
    {
        public QueueEmployeeSettingsDTO Create(QueueEmployeeSettingsDTO queueEmployeeSettingsDTO);
        public QueueEmployeeSettingsDTO Update(QueueEmployeeSettingsDTO queueEmployeeSettingsDTO);
        public int Delete(int id);
        public QueueEmployeeSettingsDTO GetById(int id);
        public IEnumerable<QueueEmployeeSettingsDTO> GetAll();


     }
}
