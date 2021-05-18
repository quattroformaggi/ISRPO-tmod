using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ISRPO.Items.Weapons
{
    public class Wakizashi : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mad Dog's Wakizashi");
			Tooltip.SetDefault("\"Kiryu-chan!\"");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.crit = 29;
			item.value = Item.buyPrice(gold: 10);
			item.buffType = BuffID.Swiftness;
			item.buffTime = 180;
			item.melee = true;
			item.width = 42;
			item.height = 46;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5f;
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}
	}
}
