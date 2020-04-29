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
    public class MushroomCore : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mushroom Core");
			Tooltip.SetDefault("The mushroom core boosts life regen by 4"
							+ "\nAll attack increased by 10%"
							+ "\nThe royal mushroom kingdom can now be yours!");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.rare = 9;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegen += 4;
			player.allDamage += 0.1f;
		}	
	}
}
