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
    [AutoloadEquip(EquipType.Balloon)]
    public class TrueBundleOfBalloons : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Allows the player to sixtuple jump"
                             + "\nIncreases jump height"
                             + "\nYou are immune to fall damage");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 32;
            item.height = 32;
            item.value = item.value = Item.buyPrice(0, 18, 0, 0);
            item.rare = 7;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.jumpBoost = true;
            player.noFallDmg = true;
            player.doubleJumpCloud = true;
            player.doubleJumpBlizzard = true;
            player.doubleJumpSandstorm = true;
            player.doubleJumpFart = true;
            player.doubleJumpSail = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CloudinaBalloon);
            recipe.AddIngredient(ItemID.BlizzardinaBalloon);
            recipe.AddIngredient(ItemID.SandstorminaBalloon);
            recipe.AddIngredient(ItemID.FartInABalloon);
            recipe.AddIngredient(ItemID.SharkronBalloon);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
