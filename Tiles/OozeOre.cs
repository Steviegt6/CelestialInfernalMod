using CelestialInfernalMod.Items.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace CelestialInfernalMod.Tiles
{
    public class OozeOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileValue[Type] = 450;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Utilities.MergeWithGeneral(Type);

            drop = ModContent.ItemType<OozingMetal>();
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Oozing Metal");
            AddMapEntry(new Color(0, 255, 127), name);
            mineResist = 2f;
            minPick = 40;
            soundType = 21;
            Main.tileSpelunker[Type] = true;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
