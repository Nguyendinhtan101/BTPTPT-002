using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MvcTAN.Models

{
    [Table("Lop")]
public class Lop
{
   

    [Key]

    public string? Person{get;set;}
    public string? FullName{get;set;}
    public string? Address{get;set;}
}