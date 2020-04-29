using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ore
{
    public class AdamantiteBolas : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 32;
            item.value = Item.sellPrice(0, 14, 0, 0);
            item.rare = 4;
            item.noMelee = true; 
            item.useStyle = 5; 
            item.useAnimation = 40; 
            item.useTime = 40; 
            item.knockBack = 10f;
            item.damage = 50;
            item.scale = 1.25f;
            item.noUseGraphic = true; 
            item.shoot = mod.ProjectileType("AdamantiteBolas");
            item.shootSpeed = 20f;
            item.UseSound = SoundID.Item1;
            item.thrown = true; 
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(391, 12);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}