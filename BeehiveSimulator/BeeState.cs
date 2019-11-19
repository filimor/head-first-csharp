using System.ComponentModel;

namespace BeehiveSimulator
{
    public enum BeeState
    {
        [Description("Ociosa")]
        Idle,

        [Description("Voando para uma flor")]
        FlyingToFlower,

        [Description("Obtendo néctar")]
        GatheringNectar,

        [Description("Voltando para a colméia")]
        ReturningToHive,

        [Description("Fabricando mel")]
        MakingHoney,

        [Description("Aposentada")]
        Retired
    }
}