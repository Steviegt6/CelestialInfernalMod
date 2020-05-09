using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CelestialInfernalMod.NPCs.TownNPCs
{
    [AutoloadHead]
    public class Manfly : ModNPC
    {
        public override string Texture
		{
			get
			{
				return "CelestialInfernalMod/NPCs/TownNPCs/Manfly";
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "Dr. Man Fly";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dr. Man Fly");
            Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 5;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 1000;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 28;
			NPCID.Sets.AttackAverageChance[npc.type] = 10;
			NPCID.Sets.HatOffsetY[npc.type] = -2;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 24;
			npc.height = 46;
			npc.aiStyle = 7;
			npc.damage = 100;
			npc.defense = 48;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit35;
			npc.DeathSound = SoundID.NPCDeath38;
			npc.knockBackResist = 1f;
            animationType = NPCID.GoblinTinkerer;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return NPC.downedPlantBoss;
        }
        public override bool? CanHitNPC(NPC target)
        {
            if (target.type == NPCID.DrManFly)
            {
                return false;
            }
            return base.CanHitNPC(target);
        }
        public override void PostAI()
        {
            int xl = (int)((npc.position.X - 2) / 16f);
            int xr = (int)((npc.position.X + npc.width + 2) / 16f);
            int xc = (int)((npc.Center.X) / 16f);
            int y = (int)((npc.position.Y + npc.height + 2) / 16f);
            if (npc.velocity.X < -4)
            {
                npc.direction = -1;
            }
            if (npc.velocity.X > 4)
            {
                npc.direction = 1;
            }
            if (npc.velocity.Y == 0)
            {
                if (Main.tile[xr, y].type == TileID.ConveyorBeltRight)
                {
                    npc.direction = -1;
                }
                if (Main.tile[xl, y].type == TileID.ConveyorBeltLeft)
                {
                    npc.direction = 1;
                }
                int type = Main.tile[xc, y].type;
                if (npc.oldVelocity.X < 0 && npc.velocity.X > 0)
                {
                    npc.direction = 1;
                }
                if (npc.oldVelocity.X > 0 && npc.velocity.X < 0)
                {
                    npc.direction = -1;
                }
                if (Math.Abs(npc.oldVelocity.X) > 4 && npc.velocity.X == 0)
                {
                    npc.velocity.Y = -6;
                    npc.velocity.X = npc.oldVelocity.X;
                }
            }
            else
            {
                if (npc.velocity.X == 0)
                {
                    npc.velocity.X = npc.direction;
                }
                npc.velocity.X += npc.direction * 0.095f;
            }
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)
		{
			int score = 500;
			for (int x = left - Main.zoneX / 2 / 16 - 1 - Lighting.offScreenTiles; x <= right + Main.zoneX / 2 / 16 + 1 + Lighting.offScreenTiles; x++)
			{
				for (int y = top - Main.zoneY / 2 / 16 - 1 - Lighting.offScreenTiles; y <= bottom + Main.zoneY / 2 / 16 + 1 + Lighting.offScreenTiles; y++)
				{
					int type = Main.tile[x, y].type;
					if (type == TileID.Glass)
                    {
						score++;
					}
                    if (type == TileID.AlchemyTable || type == TileID.ImbuingStation)
                    {
                        score += 800;
                    }
				}
			}
			return score > 800;
		}

		public override string TownNPCName()
        {
            string manfly = "Dr. Man Fly";
            switch (WorldGen.genRand.Next(3))
            {
                case 1:
                    manfly = "Dr. Fly Man";
                    break;
                case 2:
                    manfly = "Mr. Man Fly";
                    break;
            }
            switch (WorldGen.genRand.Next(6))
			{
				case 1:
					return "Dr. Delambre";
				case 2:
					return "Dr. Kleiner";
				case 3:
					return "Dr. Potionlobber";
                case 4:
                    return "Dr. Blight";
                default:
					return manfly;
			}
		}
        public override bool? CanBeHitByProjectile(Projectile projectile)
        {
            if (projectile.Name.Contains("Flask") || projectile.Name.Contains("Mine"))
            {
                return false;
            }
            return base.CanBeHitByProjectile(projectile);
        }
        public override string GetChat()
        {
            if (Main.eclipse)
            {
                switch (Main.rand.Next(3))
                {
                    case 1:
                        return "I shouldn't drink potions of cleansing so much...";
                    case 2:
                        return "Do I really look that bad?";
                    default:
                        return "Agh...Is that me?";
                }
            }
            if (Main.bloodMoon)
            {
                if (Main.raining && Main.rand.Next(4) == 0 && npc.position.Y/16 <= Main.worldSurface)
                {
                    return "Those who sit outside and wait for the rain will be feeling worse tonight.";
                }
                switch (Main.rand.Next(3))
                {
                    case 1:
                        return "Is that a nautilus I'm seeing, or is that just you fishing?";
                    case 2:
                        return "I hope that I can still experiment in peace.";
                    default:
                        return "Is this going to mess up my experiments?";
                }
            }
            else if (Main.LocalPlayer.ZoneSnow)
            {
                if (Main.rand.Next(5) == 0)
                {
                    return "I'm not used to being this cold. Oof...";
                }
            }
            else if (Main.raining && Main.rand.Next(5) == 0 && npc.position.Y / 16 <= Main.worldSurface)
            {
                return "I hope this house is watertight.";
            }
            if (Main.rand.Next(6) == 0)
            {
                if (npc.homeless)
                {
                    return "I'd like to have a house so that I can experiment and mix in peace.";
                }
                else
                {
                    return "Thanks for the house. I'm too busy to judge your interior design decisions.";
                }
            }
            switch (Main.rand.Next(5))
            {
                case 1:
                    return "Are you tired of waiting for herbs to grow? Well, that's why I'm selling them.";
                case 2:
                    return "I wouldn't recommend fighting an eldritch horror by yourself...without some potions, that is.";
                case 3:
                    return "Are you feeling off? My potion of feeling better will help.";
                case 4:
                    return "I'd prefer not to test my potions on you.";
                default:
                    return "Some people say that I was once a box office disappointment, but they've never been in a movie.";
            }
        }


        public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(ItemID.Bottle);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.BottledWater);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Daybloom);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Moonglow);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Blinkroot);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Deathweed);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Waterleaf);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Fireblossom);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Shiverthorn);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.BottledHoney);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.RegenerationPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.SwiftnessPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.GillsPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.FlaskofIchor);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.FlaskofCursedFlames);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.ArcheryPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.AmmoReservationPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.ManaRegenerationPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.MagicPowerPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.SummoningPotion);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.MasterBait);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.HotlineFishingHook);
			nextSlot++;
        }

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemID.ToxicFlask, 1);
        }

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 100;
			knockback = 4;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 20;
			randExtraCooldown = 15;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ProjectileID.ToxicFlask;
			attackDelay = 8;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 20f;
            gravityCorrection = 16f;
        }
	}
}