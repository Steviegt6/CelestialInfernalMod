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
    public class InfernalCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The core of the underworld, once held by the mutated demon"
                                + "\nYou are immune to fire blocks and lava, your melee attacks are on fire"
                                + "\nIncreased all attack by 10%."
                                + "\nYou can be now the ruler of the underworld");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 32;
            item.height = 32;
            item.value = item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 9;
            item.expert = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magmaStone = true;
            player.lavaImmune = true;
            player.fireWalk = true;
            player.allDamage += 0.1f;
        }
    }
}
