using CRMApp8.Models.CRMApp;

namespace CRMApp8.CRMApp
{
    public interface ICRMAppService
    {
        Task<List<MeetingsTasksType>> GetMeetingsTasksList();
    }
}
