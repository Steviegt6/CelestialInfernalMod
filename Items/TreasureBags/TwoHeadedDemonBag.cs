using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.TreasureBags
{
    public class TwoHeadedDemonBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 32;
            item.height = 32;
            item.rare = 9;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.TryGettingDevArmor();
            player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(8, 15));
            player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(10,20));
            player.QuickSpawnItem(mod.ItemType("InfernalCore"));
            player.QuickSpawnItem((ItemID.Hellstone), Main.rand.Next(22, 30));
            player.QuickSpawnItem(mod.ItemType("DemonFlesh"), Main.rand.Next(16, 24));
        }
    }
}
