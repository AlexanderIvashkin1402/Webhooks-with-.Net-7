using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineSendAgent.Models;

[Table("WebhookSubscriptions")]
public class WebhookSubscription
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string WebhookURI { get; set; }

    [Required]
    public string Secret { get; set; }

    [Required]
    public string WebhookType { get; set; }

    [Required]
    public string WebhookPublisher { get; set; }
}