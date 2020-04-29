using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.NPCs.Ghosts
{
    public class DungeonGhost : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 1;
        }
        public override void SetDefaults()
        {
            npc.width = 56;
            npc.height = 60;
            npc.damage = 38;
            npc.defense = 19;
            npc.lifeMax = 190;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 1800f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 23;
            aiType = 84;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneDungeon) 
                {
                return 0.05f;
                }
            else
                {
                return 0f;
                }
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Bone, Main.rand.Next(1, 6));
            if (Main.rand.Next(10) < 1)
            {
                Item.NewItem(npc.getRect(), ItemID.Muramasa, Main.rand.Next(1, 2));
            }
        }
    }
}
