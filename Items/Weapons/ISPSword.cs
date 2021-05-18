using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items.Weapons
{
	public class ISPSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("ISP Sword");
			Tooltip.SetDefault("Can be wield by those of 09.02.07 faction.\n");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.crit = -5;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 100;
			item.value = Item.sellPrice(gold: 1);
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ViolisBar>(), 3);
            recipe.AddIngredient(ItemID.HellstoneBar, 3);
			recipe.AddIngredient(ItemID.MeteoriteBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}