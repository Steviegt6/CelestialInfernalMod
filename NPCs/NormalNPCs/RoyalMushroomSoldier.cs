using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class RoyalMushroomSoldier : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 20;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.damage = 16;
            npc.defense = 2;
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 150f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 3;
            aiType = NPCID.GraniteGolem;
            animationType = NPCID.GraniteGolem;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 1f;
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Mushroom, Main.rand.Next(3, 8));
        }
    }
}
