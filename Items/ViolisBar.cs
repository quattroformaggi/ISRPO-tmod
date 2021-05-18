using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items
{
    public class ViolisBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violis Bar");
            Tooltip.SetDefault("Used to craft Violis gear...and...");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(silver: 50);

            item.autoReuse = true;
            item.useTurn = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;

            item.consumable = true;
            item.maxStack = 99;

            //item.createTile = TileType<Tiles.TMMCBars>();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ViolisOre>(), 3);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
