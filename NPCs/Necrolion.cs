using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.NPCs
{
	public class Necrolion : ModNPC
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Necro Antlion"); 
            Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults() 
		{
            npc.CloneDefaults(NPCID.Antlion);
            
            npc.damage = 25;
			npc.defense = 18;
            npc.lifeMax = 300;
            animationType = 69;
		}
	}
}