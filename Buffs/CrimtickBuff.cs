using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace CelestialInfernalMod.Buffs
{
    public class CrimtickBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Crimtick");
			Description.SetDefault("The only thing it spreads is pain");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[mod.ProjectileType("Crimtick")] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}
