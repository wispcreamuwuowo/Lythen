using Terraria.ID;
using Terraria.ModLoader;

namespace Lythen.Items
{
	public class EmeraldSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EmeraldSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Funfact: The Terrarian made this sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 23;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 4);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}