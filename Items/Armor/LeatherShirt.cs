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
    public class LeatherShirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leather Shirt");
                Tooltip.SetDefault("Increases your maximum capacity of minions"
                                + "\nMinion damage increased by 4%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 15000;
            item.rare = 1;
            item.defense = 4; // The Defence value for this piece of armour.
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.04f;
            player.maxMinions += 1;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(259, 8);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
            r = new ModRecipe(mod);
            r.AddIngredient(1330, 40);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}