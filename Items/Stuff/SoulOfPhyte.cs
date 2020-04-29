using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Stuff
{
	public class SoulOfPhyte : ModItem
	{
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("The essence of tropical creatures");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

		public override void SetDefaults()
        {
			item.width = 26;
			item.height = 26;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 0, 15, 0);
			item.rare = 3;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
