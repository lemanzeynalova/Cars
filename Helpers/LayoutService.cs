using Cars.Context;
using Cars.Models;

namespace Cars.Helpers
{
    public class LayoutService
    {
        CarsDbContext _context {  get; }
        public LayoutService(CarsDbContext context)
        {
            _context = context;
        }
        public async Task<Setting> GetSettingAsync()
            => await _context.Settings.FindAsync(1);
    }
}
