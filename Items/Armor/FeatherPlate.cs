using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class FeatherPlate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Feather-Covered Chestplate");
                Tooltip.SetDefault("Increases ranged damage by 5%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 60000;
            item.rare = 1;
            item.defense = 5; // The Defence value for this piece of armour.
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05f;
            player.rangedCrit += 5;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(320, 30);
            r.AddIngredient(1257, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
            r = new ModRecipe(mod);
            r.AddIngredient(320, 30);
            r.AddIngredient(57, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}