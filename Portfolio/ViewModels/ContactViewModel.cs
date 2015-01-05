namespace Portfolio.ViewModels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ContactViewModel
    {
        [Required]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
        ErrorMessage = "Le format de l'adresse email est invalide.")]
        public string YourMail { get; set; }

        [Required]
        public string YourMessage { get; set; }
    }
}