using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace CelestialInfernalMod.Buffs
{
    public class EaterBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Leather-Skinned Beast");
			Description.SetDefault("It eats souls for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[mod.ProjectileType("LeatherEater")] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}
