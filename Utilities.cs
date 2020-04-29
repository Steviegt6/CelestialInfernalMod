using CelestialInfernalMod.NPCs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CelestialInfernalMod
{
    public static class Utilities
    {        
		#region Object Extensions
		//public static CelestialInfernalPlayer Celestial(this Player player) => player.GetModPlayer<CelestialInfernalPlayer>();
		public static CelestialInfernalGlobalNPC Celestial(this NPC npc) => npc.GetGlobalNPC<CelestialInfernalGlobalNPC>();
		//public static CelestialInfernalGlobalItem Celestial(this Item item) => item.GetGlobalItem<CelestialInfernalGlobalItem>();
		//public static CelestialInfernalGlobalProjectile Celestial(this Projectile proj) => proj.GetGlobalProjectile<CelestialInfernalGlobalProjectile>();
		#endregion

		#region Player Utilities
		// These functions factor in TML 0.11 allDamage to get the player's total damage boost which affects the specified class.
		public static float MeleeDamage(this Player player) => player.allDamage + player.meleeDamage - 1f;
		public static float RangedDamage(this Player player) => player.allDamage + player.rangedDamage - 1f;
		public static float MagicDamage(this Player player) => player.allDamage + player.magicDamage - 1f;
		public static float MinionDamage(this Player player) => player.allDamage + player.minionDamage - 1f;
		public static float ThrownDamage(this Player player) => player.allDamage + player.thrownDamage - 1f;
		public static float AverageDamage(this Player player) => player.allDamage + (player.meleeDamage + player.rangedDamage + player.magicDamage + player.minionDamage + player.thrownDamage - 5f) / 5f;

		public static bool IsUnderwater(this Player player) => Collision.DrownCollision(player.position, player.width, player.height, player.gravDir);
		public static bool InSpace(this Player player)
		{
			float x = Main.maxTilesX / 4200f;
			x *= x;
			float spaceGravityMult = (float)((player.position.Y / 16f - (60f + 10f * x)) / (Main.worldSurface / 6.0));
			return spaceGravityMult < 1f;
		}
		public static bool PillarZone(this Player player) => player.ZoneTowerStardust || player.ZoneTowerSolar || player.ZoneTowerVortex || player.ZoneTowerNebula;
		public static bool InventoryHas(this Player player, params int[] items) => player.inventory.Any(item => items.Contains(item.type));
		#endregion
	}
}