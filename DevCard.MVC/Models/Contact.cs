using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard.MVC.Models
{
	public class Contact
	{
		[Required(ErrorMessage = "این فیلد اجباری است")]
		[MinLength(3,ErrorMessage = "حداقل طول نام، ۳ کاراکتر است")]
		[MaxLength(100, ErrorMessage = "حداکثر طول نام، ۱۰۰ کاراکتر است")]
		public string Name { get; set; }
		[EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
		[Required(ErrorMessage = "این فیلد اجباری است")]
		public string Email { get; set; }
		public string Message { get; set; }
		public int Service { get; set; }
		public SelectList Services { get; set; }

	}
}
