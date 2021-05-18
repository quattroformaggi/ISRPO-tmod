using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ISRPO.NPCs
{
    [AutoloadHead]
    public class NPCQuestin : ModNPC
    {
        public override string Texture
        {
            get { return "ISRPO/NPCs/NPCQuestin"; }
        }
        public override string[] AltTextures
        {
            get { return new[] { "ISRPO/NPCs/NPCQuestin_Alt" }; }
        }
        public override bool Autoload(ref string name)
        {
            name = "Man";
            return mod.Properties.Autoload;
        }
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 5;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 20;
            npc.height = 30;
            npc.aiStyle = 7; // Town NPC AI Style
            npc.damage = 17;
            npc.defense = 20;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            // This will allow us to make an NPC spawn if we have a certain item
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                    continue;

                foreach (Item item in player.inventory)
                    if (item.type == mod.ItemType("Bulka"))
                        return true;
            }
            return false;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Kiryu";
                case 1:
                    return "Majima";
                case 2:
                    return "Nishikiyama";
                default: // Default is the default if no other case is true. In this case if the random number is 3 or more
                    return "Questin";
            }
        }

        public override string GetChat()
        {
            int otherNPC = NPC.FindFirstNPC(NPCID.Merchant);
            if (otherNPC >= 0 && Main.rand.NextBool(4))
            {
                return "This guy " + Main.npc[otherNPC].GivenName + ", he sells cool stuff, you know that?";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "Real yakuzas use gamepad.";
                case 1:
                    return "Dame da ne... dame yo... dame dane yo...";
                case 2:
                    return "No mercy for the mobs.";
                default:
                    return "Wanna go on another quest?";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "Quest?";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
                shop = true;// This is makes it a shop
            else
                Main.npcChatText = "No quests available at the moment.";//can be replaced with functional
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            // For every slot, you must have these lines.
            shop.item[nextSlot].SetDefaults(mod.ItemType("Bulka"));
            nextSlot++;
            // You can have a max of 40?
            shop.item[nextSlot].SetDefaults(ItemID.GoldOre);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Meteorite);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Hellstone);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Obsidian);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ViolisOre"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Wakizashi"));
            // You can also have conditions
            if (Main.moonPhase == 2) // The Phase of the Moon
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoonCharm);
                nextSlot++;
            }
            if (Main.hardMode) // If in hardmode
            {
                shop.item[nextSlot].SetDefaults(ItemID.GreaterHealingPotion);
                nextSlot++;
            }
            if (Main.LocalPlayer.HasBuff(BuffID.Swiftness)) // If we have a certain buff
            {
                shop.item[nextSlot].SetDefaults(ItemID.RegenerationPotion);
                nextSlot++;
            }
            if(Main.bloodMoon)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SharkToothNecklace);
                nextSlot++;
            }

        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("ISPSword"));
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 25;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 27;
            randExtraCooldown = 25;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.SwordBeam;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 5.4f;
            randomOffset = 2f;
        }


        // This is for if you want custom spawn conditions
        // This example will check for the TMMCTile and TMMCWall
        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            int score = 0;
            for (int x = left; x <= right; x++)
            {
                for (int y = top; y <= bottom; y++)
                {
                    int type = Main.tile[x, y].type;
                    if (type == TileID.Stone)//каменный дом
                        score++;
                    if (Main.tile[x, y].wall == WallID.Stone)//с каменными стенами
                        score++;
                }
            }
            return score >= (right - left) * (bottom - top) / 2;
        }

    }
}
