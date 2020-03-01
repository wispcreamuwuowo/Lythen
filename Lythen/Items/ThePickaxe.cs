using Terraria.ID;
using Terraria.ModLoader;

namespace Lythen.Items
{
	public class ThePickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ThePickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Is it a sword or is it a pickaxe?");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.pick = 40;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(ItemID.Wood, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}