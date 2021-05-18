using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items.Weapons
{
    public class Bow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violis Bow");
            Tooltip.SetDefault("...");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(12, 19);//24x39
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(gold: 1);
            item.useTime = 10;
            item.useAnimation = 13;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.ranged = true;
            item.damage = 30;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = ProjectileID.UFOLaser;//WoodenArrowFriendly
            item.shootSpeed = 7f;
            item.knockBack = 2.2f;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ViolisBar>(), 15); // Uses Bar123
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
