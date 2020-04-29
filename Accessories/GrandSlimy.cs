using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Accessories
{
    public class GrandSlimy : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grand Slimy");
			Tooltip.SetDefault("The slimy boi is now with you and provides you benefits!"
							+ "\nAll attack increased by 5% and damage reduction increased by 10%");
		}
		public override void SetDefaults()
		{
			item.width = 21;
			item.height = 21;
			item.rare = 9;
			item.value = Item.buyPrice(0, 2, 10, 0);
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.05f;
			player.endurance += 0.1f;
		}	
	}
}
