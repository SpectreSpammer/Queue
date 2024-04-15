using AutoMapper;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository.IRepository;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Models;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository
{
    public class QueueSettingsRepositoryImpl : BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository.IRepository.IQueueSettingsRepository
    {
        private readonly ApplicationDbContext _db;

        private readonly IMapper _mapper;

        public QueueSettingsRepositoryImpl(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public QueueEmployeeSettingsDTO Create(QueueEmployeeSettingsDTO queueEmployeeSettingsDTO)
        {
            var queueSetting = _mapper.Map<QueueEmployeeSettingsDTO, QueueEmployeeSettings>(queueEmployeeSettingsDTO);

        

            var addedQueue = _db.queueEmployeeSettings.Add(queueSetting);

            _db.SaveChanges();

            return _mapper.Map<QueueEmployeeSettings, QueueEmployeeSettingsDTO>(addedQueue.Entity);
        }

        public int Delete(int queueGuid)
        {
            var queueSetting = _db.queueEmployeeSettings.FirstOrDefault(u => u.QueueGuid == queueGuid);

            if (queueSetting != null)
            {
                _db.queueEmployeeSettings.Remove(queueSetting);
                return _db.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<QueueEmployeeSettingsDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<QueueEmployeeSettings>, IEnumerable<QueueEmployeeSettingsDTO>>(_db.queueEmployeeSettings);
        }

        public QueueEmployeeSettingsDTO GetById(int queueGuid)
        {
            var queueSetting = _db.queueEmployeeSettings.FirstOrDefault(u => u.QueueGuid == queueGuid);

            if (queueSetting != null)
            {
                _mapper.Map<QueueEmployeeSettings, QueueEmployeeSettingsDTO>(queueSetting);
            }
            return new QueueEmployeeSettingsDTO();
        }

        public QueueEmployeeSettingsDTO Update(QueueEmployeeSettingsDTO queueEmployeeSettingsDTO)
        {
            var queueFromDb = _db.queueEmployeeSettings.FirstOrDefault(u => u.QueueGuid == queueEmployeeSettingsDTO.QueueGuid);
            if (queueFromDb != null)
            {
                queueFromDb.QueueName = queueEmployeeSettingsDTO.QueueName;
                _db.queueEmployeeSettings.Update(queueFromDb);
                _db.SaveChanges();
                return _mapper.Map<QueueEmployeeSettings, QueueEmployeeSettingsDTO>(queueFromDb);
            }

            return queueEmployeeSettingsDTO;

        }
    }
}
