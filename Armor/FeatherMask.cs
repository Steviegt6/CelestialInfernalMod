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
    [AutoloadEquip(EquipType.Head)]
    public class FeatherMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Feather-Covered Mask");
                Tooltip.SetDefault("Increases bullet damage by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 40000;
            item.rare = 1;
            item.defense = 4; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("FeatherPlate") && legs.type == mod.ItemType("FeatherLegs");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(8, 3600);
        }
        public override void UpdateEquip(Player player)
        {
            player.bulletDamage += 0.1f;
            player.rangedCrit += 5;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(320, 20);
            r.AddIngredient(1257, 10);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
            r = new ModRecipe(mod);
            r.AddIngredient(320, 20);
            r.AddIngredient(57, 10);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}