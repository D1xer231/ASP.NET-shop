using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MethShop.Models;
public class Blog
{
    [Key]
    [BindNever]
    public int Id { get; set; }


    [Display(Name = "Введите заголовок")]
    [Required(ErrorMessage = "Заголовок обязателен для заполнения")]
    [StringLength(50, ErrorMessage = "Заголовок не может быть длиннее 50 символов")]
    public string Title { get; set; }

    [Display(Name = "Введите аноннс")]
    [Required(ErrorMessage = "Аноннс обязателен для заполнения")]
    [StringLength(50, ErrorMessage = "Аноннс не может быть длиннее 50 символов")]
    public string Anons { get; set; }

    [Display(Name = "Введите текст")]
    [Required(ErrorMessage = "Текст обязателен для заполнения")]
    [StringLength(100, ErrorMessage = "Текст не может быть длиннее 100 символов")]
    public string FullText { get; set; }

}
