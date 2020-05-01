using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class JMimicGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dart Spewer"); 
            Tooltip.SetDefault("Pew! Pew pew!");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.width = 32;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.rare = 6;
			item.noMelee = false;
            item.knockBack = 5f;
			item.useAmmo = AmmoID.Dart;
			item.UseSound = SoundID.Item11;
			item.shoot = 267;
			item.shootSpeed = 25f;
            item.autoReuse = true;
			item.ranged = true;
		}
        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .5f;
		}
	}
}