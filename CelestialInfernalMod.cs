using CelestialInfernalMod.Items.Materials;
using CelestialInfernalMod.Items.SummonItems;
using CelestialInfernalMod.Items.Weapons.Melee;
using CelestialInfernalMod.NPCs.EnragedDemonBoss;
using CelestialInfernalMod.NPCs.GrandSlimeBoss;
using CelestialInfernalMod.NPCs.HigherPixieBoss;
using CelestialInfernalMod.NPCs.MushKing;
using CelestialInfernalMod.NPCs.PutridCoagulationBoss;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace CelestialInfernalMod
{
	public class CelestialInfernalMod : Mod
	{
		internal static CelestialInfernalMod instance;

        #region Load
        public override void Load()
        {
			instance = this;

            CelestialLocalization.AddLocalizations();
		}
		#endregion

		public override void PostSetupContent()
		{
			// Showcases mod support with Boss Checklist without referencing the mod
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			if (bossChecklist != null)
			{
				bossChecklist.Call(
					"AddBoss",
					0.1f,
					new List<int> { ModContent.NPCType<GrandSlime>() },
					this, // Mod
					"$Mods.CelestialInfernalMod.NPCName.GrandSlime",
					(Func<bool>)(() => CelestialInfernalModWorld.downedGrandSlime),
					ModContent.ItemType<SlimyMess>(),
					"$Mods.CelestialInfernalMod.BossSpawnInfo.GrandSlime"
				);
				bossChecklist.Call(
					"AddBoss",
					2.1f,
					ModContent.NPCType<MushroomKing>(),
					this,
					"$Mods.CelestialInfernalMod.NPCName.MushroomKing",
					(Func<bool>)(() => CelestialInfernalModWorld.downedMushroomKing),
					ModContent.ItemType<SuspiciousLookingMushroom>(),
					"$Mods.CelestialInfernalMod.BossSpawnInfo.MushroomKing"
				);
				bossChecklist.Call(
					"AddBoss",
					3.1f,
					ModContent.NPCType<EnragedDemon>(),
					this,
					"$Mods.CelestialInfernalMod.NPCName.EnragedDemon",
					(Func<bool>)(() => CelestialInfernalModWorld.downedEnragedDemon),
					ModContent.ItemType<DemonicIdol>(),
					"$Mods.CelestialInfernalMod.BossSpawnInfo.EnragedDemon"
				);
				bossChecklist.Call(
					"AddBoss",
					5.1f,
					ModContent.NPCType<PutridCoagulation>(),
					this,
					"$Mods.CelestialInfernalMod.NPCName.PutridCoagulation",
					(Func<bool>)(() => CelestialInfernalModWorld.downedPutridCoagulation),
					ModContent.ItemType<GrossSpine>(),
					"$Mods.CelestialInfernalMod.BossSpawnInfo.PutridCoagulation"
				);
				bossChecklist.Call(
					"AddBoss",
					6.1f,
					ModContent.NPCType<HigherPixie>(),
					this,
					"$Mods.CelestialInfernalMod.NPCName.HigherPixie",
					(Func<bool>)(() => CelestialInfernalModWorld.downedHigherPixie),
					ModContent.ItemType<PixieMedalion>(),
					"$Mods.CelestialInfernalMod.BossSpawnInfo.HigherPixie"
				);
			}
		}

        private static ModRecipe GetNewRecipe() => new ModRecipe(ModContent.GetInstance<CelestialInfernalMod>());

		public override void AddRecipes()
		{
            ModRecipe recipe = GetNewRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WandofSparking, 1);
			recipe.AddRecipe();

			recipe = GetNewRecipe();
			recipe.AddIngredient(ModContent.ItemType<Rallyrang>());
			recipe.AddIngredient(ModContent.ItemType<EnchantedShard>(), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();

			recipe = GetNewRecipe();
			recipe.AddIngredient(ModContent.ItemType<EnchantedShard>(), 8);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();

			recipe = GetNewRecipe();
			recipe.AddIngredient(ModContent.ItemType<EnchantedShard>(), 8);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();
		}

        #region Update Server Boolean
        public static void UpdateServerBoolean()
        {
            if (Main.netMode == NetmodeID.Server)
            {
                NetMessage.SendData(7, -1, -1, null, 0, 0f, 0f, 0f, 0, 0, 0);
            }
        }
        #endregion
	}
}