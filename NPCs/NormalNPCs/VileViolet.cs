using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class VileViolet : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 52;
            npc.height = 36;
            npc.damage = 40;
            npc.defense = 20;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 500f;
            npc.knockBackResist = 0.30f;
            npc.aiStyle = 13;
            aiType = 43;
            animationType = 43;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedBoss3 == true && spawnInfo.player.ZoneCorrupt) 
                {
                return 0.1f;
                }
            else
                {
                return 0f;
                }
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 68, Main.rand.Next(1, 26));
        }
    }
}
