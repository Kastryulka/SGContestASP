namespace testASPCoreMVC_2.Enums
{
    using System.ComponentModel.DataAnnotations; // для атрибута Display

    public enum Languages
    {
        [Display(Name = "python3")]
        Python,
        [Display(Name = "c#")]
        CS,
        [Display(Name = "c")]
        C,
        [Display(Name = "c++")]
        CPP
    }
}
