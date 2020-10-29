using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels
{
    /// <summary>
    /// نوع محموله
    /// </summary>
    public class ViewModelCargoType
    {
        [Display(Name = "شناسه")] public byte TypeID { get; set; }
        [Display(Name = "نوع محموله")] public string Type { get; set; }
    }
}
