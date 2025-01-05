using UpsellPageAPI.Data;
using UpsellPageAPI.Entities;
using UpsellPageAPI.Interfaces;

namespace UpsellPageAPI.Services
{
    public class ActivityService : IActivityService
    {
        private readonly UpsellPageDbContext _context;

        public ActivityService(UpsellPageDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            return _context.Activities.ToList();
        }

        public Activity GetActivityById(int id)
        {
            return _context.Activities.FirstOrDefault(a => a.Id == id);
        }

        public void AddActivity(Activity activity)
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();
        }

        public void UpdateActivity(Activity activity)
        {
            _context.Activities.Update(activity);
            _context.SaveChanges();
        }

        public void DeleteActivity(int id)
        {
            var activity = _context.Activities.Find(id);
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                _context.SaveChanges();
            }
        }
    }
}
