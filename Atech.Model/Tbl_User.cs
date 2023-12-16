using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atech.Model
{
	public class Tbl_User
	{
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
		public string Gender { get; set; }
		public string ProfileImage { get; set; }
		public DateTime? CreatedOn { get; set; } = DateTime.Now;
		public DateTime? UpdatedOn { get; set; } = DateTime.Now;
	}
}
