using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class RoyalMushroomCaster : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 22;
            npc.height = 26;
            npc.damage = 18;
            npc.defense = 0;
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 150f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 8;
            aiType = NPCID.DarkCaster;
            animationType = NPCID.DarkCaster;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (CelestialInfernalModWorld.downedMushroomKing) 
                {
                    return SpawnCondition.OverworldDaySlime.Chance * 1f;
                }
            else
            {
                return 0f;
            }
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GlowingMushroom, Main.rand.Next(2, 6));
            if (Main.rand.Next(10) < 1 && CelestialInfernalModWorld.downedMushroomKing)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RoyalMushroomStaff"), Main.rand.Next(1, 2));
            }
        }
    }
}
