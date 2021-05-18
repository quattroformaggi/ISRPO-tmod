using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;
using ISRPO.Items;

namespace ISRPO.Items.Tools
{
    public class Axe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violis Axe");
            Tooltip.SetDefault("Can be used 'till\nMythril/Orichalcum one.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(gold: 1);
            item.autoReuse = true;
            item.useTime = 13;
            item.useAnimation = 25;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.damage = 32;
            item.knockBack = 7.2f;
            item.axe = 80;
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
