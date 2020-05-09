using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using CelestialInfernalMod.Projectiles.Minions;
using static Terraria.ModLoader.ModContent;

namespace CelestialInfernalMod.Buffs
{
    public class DripplerBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Drippler");
			Description.SetDefault("It flies into enemies for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (player.ownedProjectileCounts[ProjectileType<DripplerMinion>()] > 0)
			{
				player.buffTime[buffIndex] = 18000;
			}
			else
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}
