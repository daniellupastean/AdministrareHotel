using System;
namespace LibrarieModele
{
    public enum TipCamera
    {
        Single = 1,
        Dubla = 2,
        Twin = 3,
        Matrimoniala = 4,
        Tripla = 5,
        Quad = 6
    };

    [Flags]
    public enum FacilitatiCamera
    {
        Niciuna = 0,
        TV = 1,
        Internet = 2,
        Seif = 4,
        Jacuzzi = 8,
        Frigider = 16
    };
}
