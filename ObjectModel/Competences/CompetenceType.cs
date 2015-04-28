namespace ObjectModel.Competences
{
    using System.ComponentModel;

    /// <summary>
    /// Defines the types of competences.
    /// </summary>
    public enum CompetenceType
    {
        [Description("GENERAL_TECHNICAL_COMPETENCES")]
        TechnicalCompetence = 1,

        [Description("GENERAL_HUMAN_COMPETENCES")]
        HumanCompetence = 2
    }
}