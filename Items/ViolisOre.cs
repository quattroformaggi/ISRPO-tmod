using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ISRPO.Items
{
    public class ViolisOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violis Ore");
            Tooltip.SetDefault("80s hit.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(12);
            item.rare = ItemRarityID.LightPurple;
            item.value = Item.sellPrice(silver: 12);

            item.autoReuse = true;
            item.useTurn = true;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;

            item.consumable = true;
            item.maxStack = 999;

            item.createTile = TileType<Tiles.ViolisOreBlock>();
        }
    }
}
