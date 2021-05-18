using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ISRPO.Items.Food
{
    public class Bulka : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Tastes dry.\nIs not a weapon.");
		}

		public override void SetDefaults()
		{
			item.width = 33;
			item.height = 30;
			item.consumable = true;
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.LiquidsWaterLava;
			item.buffType = ModContent.BuffType<Buffs.BadFood>();
			item.buffTime = 1800; //ticks; 60ticks/60 = 1sec
			//item.buffType = BuffID.Suffocation;
			//item.buffTime = 450;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 30;
			item.useTime = 15;
			item.useAnimation = 17;
			item.value = Item.buyPrice(copper:99);
			item.useTime = 15;
			item.useTurn = true;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 2);
			//recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
