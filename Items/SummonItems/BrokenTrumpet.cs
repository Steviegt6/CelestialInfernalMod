using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CelestialInfernalMod.NPCs.MushKing;

namespace CelestialInfernalMod.Items.SummonItems
{
	public class BrokenTrumpet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Trumpet");
			Tooltip.SetDefault("Its sound attracts a detester to your location");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 14;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 1;
			item.useStyle = 1;
			item.useTime = 20;
			item.useAnimation = 20;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BrokenTrumpet");
			item.useTurn = true;
			item.autoReuse = false;
			item.useStyle = 5;
		}
		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(ModContent.NPCType<MushroomKing>());
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<MushroomKing>());
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y);

			return true;
		}
	}
}

