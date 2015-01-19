using MusicShop.Models;

namespace MusicShopManager.Interfaces
{
    using System;

    public interface IAcousticGuitar : IGuitar
    {
        bool CaseIncluded { get; }

        StringMaterial StringMaterial { get; }
    }
}
