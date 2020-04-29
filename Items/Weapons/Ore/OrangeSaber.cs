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

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class OrangeSaber : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Orange Phasesaber"); 
		}
		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.YellowPhasesaber);
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(169, 600);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("OrangeBlade"), 1);
            recipe.AddIngredient(502, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}