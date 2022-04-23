using Microsoft.AspNetCore.Mvc.Rendering;
using Party.Data.Entities;

namespace Party.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync(IEnumerable<Entrance> filter);
    }
}
