using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Accessories
{
    [AutoloadEquip(EquipType.Shoes)]
    public class HotFrostBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Allows flight, hyper fast running, and extra mobility on ice"
                             + "\n20 % increased movement speed"
                             + "\nProvides the ability to walk on water and lava"
                             + "\nGrants immunity to fire blocks and 8 seconds of immunity to lava");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 32;
            item.height = 32;
            item.value = item.value = Item.buyPrice(0, 15, 0, 0);
            item.rare = 8;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 10f;
            player.moveSpeed += 0.2f;
            player.rocketBoots = 3;
            player.lavaMax += 500;
            player.fireWalk = true;
            player.waterWalk = true;
            player.iceSkate = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddIngredient(ModContent.ItemType<GreatGel>(), 30);
            recipe.AddIngredient(ModContent.ItemType<DensePixieDust>(), 30);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
