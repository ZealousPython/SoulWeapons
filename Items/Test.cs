using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradebleWeapons.Items
{
	public class Test : ModItem
	{
		private double damageMultiplier = 1;
		private int souls = 0;
		private int requiredSouls =100;
		private int level = 1;
		private const double damageScaling = 0.6; //the damage multiplier by level 
		private const int fixedDamageScaling = 2; //the fixed damage increase by level 
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Souls: "+souls+"\nNext LvL: "+requiredSouls);

		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		public override bool? CanBurnInLava(){
			return false;
		}
		public void Start() 
		{
			/// <summary>
		/// Start is called on the frame when a script is enabled just before
		/// any of the Update methods is called the first time.
		/// </summary>
			Item.damage *= (int)damageMultiplier;


		}
		/// <summary>
		/// Update is called every frame, if the MonoBehaviour is enabled.
		/// </summary>
		void Update()
		{
			damageMultiplier += 1;
			Item.damage *= (int)damageMultiplier;
			
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit){
			
		}
		public override void RightClick(Player player){
			
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar,5);
			recipe.Register();
		}
	}
}