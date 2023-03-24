using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgentWeb.Models;

[Table("WebhookSecret")]
public class WebhookSecret
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Secret { get; set; }  

    [Required]
    public string Publisher { get; set; }
}