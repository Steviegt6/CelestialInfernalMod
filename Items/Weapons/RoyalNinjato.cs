using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class RoyalNinjato : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Royal Ninjato");
			Tooltip.SetDefault("The mighty blade of the ninja inside King Slime");
		}

		public override void SetDefaults() 
		{
			item.damage = 24;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 1;
            item.scale = 1.2f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}