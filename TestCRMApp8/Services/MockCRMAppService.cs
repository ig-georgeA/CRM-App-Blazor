using CRMApp8.Models.CRMApp;

namespace CRMApp8.CRMApp
{
    public class MockCRMAppService : ICRMAppService
    {
        public Task<List<MeetingsTasksType>> GetMeetingsTasksList()
        {
            return Task.FromResult<List<MeetingsTasksType>>(new());
        }
    }
}
