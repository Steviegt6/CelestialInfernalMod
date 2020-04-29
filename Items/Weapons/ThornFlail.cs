using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
    public class ThornFlail : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 2;
            item.noMelee = true; 
            item.useStyle = 5; 
            item.useAnimation = 40; 
            item.useTime = 40; 
            item.knockBack = 7.5f;
            item.damage = 20;
            item.scale = 1.25f;
            item.noUseGraphic = true; 
            item.shoot = mod.ProjectileType("ThornFlail");
            item.shootSpeed = 15f;
            item.UseSound = SoundID.Item1;
            item.melee = true; 
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(191, 1);
            recipe.AddIngredient(3281, 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}