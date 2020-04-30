using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class WandOfWetting : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wand of Wetting"); 
			Tooltip.SetDefault("Spews a soaker stream");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.width = 32;
			item.height = 32;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.value = Item.buyPrice(0, 0, 75, 0);
			item.rare = 1;
			item.knockBack = 1;
			item.mana = 6;
			item.UseSound = SoundID.Item8;
			item.shoot = ProjectileID.WaterStream;
			item.shootSpeed = 7.5f;
            item.noMelee = true;
			item.autoReuse = true;
			item.magic = true;
		}

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Glowstick, 5);
            r.AddIngredient(ItemID.PalmWood, 10);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
	}
}