using Terraria.ModLoader;
using Terraria.ID;

namespace ISRPO.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BunnyMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kroll");
			Tooltip.SetDefault("He wants pitza...");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.defense = 121212;
		}
		public override bool DrawHead() {return false;}
	}
}