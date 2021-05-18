using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items.Tools
{
    public class Pickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violis Pick"); 
            Tooltip.SetDefault("...");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(gold: 1);
            item.autoReuse = true;
            item.useTime = 13;
            item.useAnimation = 24;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.damage = 12;
            item.knockBack = 2.1f;
            item.pick = 105; // Slightly better than a molten pickaxe
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ViolisBar>(), 12); // Uses Bar123
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
