using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ISRPO.Buffs
{
    public class BadFood : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Eatery Dessert");
            Description.SetDefault("Suffocating, but fed\nAlso speed down...");
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed -= 0.75F;
            player.wellFed = true;
            player.suffocating = true;
        }
    }
}
