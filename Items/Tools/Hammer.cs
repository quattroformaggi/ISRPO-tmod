using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items.Tools
{
    public class Hammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violis Hammer");
            Tooltip.SetDefault("Could it be used\ntobreak demon altars...?");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(gold: 1);
            item.autoReuse = true;
            item.useTime = 13;
            item.useAnimation = 31;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.damage = 23;
            item.knockBack = 7.2f;
            item.hammer = 81; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ViolisBar>(), 8); 
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
