using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items.Accessories
{
    class Alloy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Viothril Alloy");
            Tooltip.SetDefault("Increases your speed & fighting capabilities.\nPassive armor, they say...");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(18,20);
            item.accessory = true;
            item.value = Item.sellPrice(silver: 12);
            item.rare = ItemRarityID.Blue;
            item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxRunSpeed += 0.44f;
            player.meleeSpeed += 0.44f;
            player.magicDamageMult += 0.1f;
            player.meleeDamageMult += 0.1f;
            player.rangedDamageMult += 0.1f;
            player.AddBuff(BuffID.Ironskin,1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ViolisBar>(), 4);
            recipe.AddIngredient(ItemID.MythrilBar, 4);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
