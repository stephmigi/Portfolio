namespace ObjectModel.Realisations
{
    using System.ComponentModel;

    public enum RealisationType
    {
        [Description("GENERAL_REALISATIONTYPE_SCHOOL")]
        SchoolProject = 1,

        [Description("GENERAL_REALISATIONTYPE_BUSINESS")]
        EntrepriseProject = 2,

        [Description("GENERAL_REALISATIONTYPE_OTHER")]
        Other = 3
    }
}