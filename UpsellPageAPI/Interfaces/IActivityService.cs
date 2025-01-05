using UpsellPageAPI.Entities;

namespace UpsellPageAPI.Interfaces
{
    public interface IActivityService
    {
        IEnumerable<Activity> GetAllActivities();
        Activity GetActivityById(int id);
        void AddActivity(Activity activity);
        void UpdateActivity(Activity activity);
        void DeleteActivity(int id);
    }
}
