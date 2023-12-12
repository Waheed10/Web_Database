using System.ComponentModel.DataAnnotations;

namespace Assign2_linq.Data
{
    public class EditModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string sname { get; set; }

        
        public string major { get; set; }

       
        public string standing { get; set; }

    }
}
