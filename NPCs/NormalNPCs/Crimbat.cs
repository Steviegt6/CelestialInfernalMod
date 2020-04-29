using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class Crimbat : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 38;
            npc.height = 52;
            npc.damage = 45;
            npc.defense = 25;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 2500f;
            npc.knockBackResist = 0.80f;
            npc.aiStyle = 22;
            aiType = NPCID.IchorSticker;
            animationType = NPCID.GiantBat;
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Vertebrae, Main.rand.Next(3, 8));
            if (Main.hardMode && Main.rand.NextFloat() < 0.75f);
                Item.NewItem(npc.getRect(), ItemID.Ichor, 1 + Main.rand.Next(5));
        }
    }
}
