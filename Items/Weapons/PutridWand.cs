using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class PutridWand : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Putrid Wand"); 
            Item.staff[item.type] = true;
		}
        public override void SetDefaults()
		{
			item.damage = 40;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 70, 0);
			item.rare = 3;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 12;
			item.UseSound = SoundID.Item20;
			item.shoot = ProjectileID.CursedFlameFriendly;
			item.shootSpeed = 8f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 18); //modded materials
			recipe.AddIngredient(ItemID.Vilethorn, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 18); //modded materials
			recipe.AddIngredient(ItemID.CrimsonRod, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}