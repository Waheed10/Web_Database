using System.ComponentModel.DataAnnotations;

namespace Assign2_linq.Data
{
    public class DeleteModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string sname { get; set; }
        public string fname { get; set; }
    }
}
