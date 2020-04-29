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
    [AutoloadEquip(EquipType.Wings)]
    public class PutridWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A brilliant god-blooded inferno of curses");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 42;
            item.height = 42;
            item.value = item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 4;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 60;
        }
        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1.5f;
			constantAscend = 0.2f;
		}
		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 5f;
			acceleration *= 1.5f;
		}
        public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 10);
            recipe.AddIngredient(ItemID.RubyStaff, 2);
            recipe.AddIngredient(ItemID.TungstenShortsword, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 10);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
