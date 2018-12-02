using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
    public class BeetleSickle : DeathItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beetle Sickle");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 263;
            item.width = 200;
            item.height = 200;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeetleHusk, 4);    
            recipe.AddIngredient(null, "TurtleSickle");    recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}