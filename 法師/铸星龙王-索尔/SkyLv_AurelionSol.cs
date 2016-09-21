namespace SkyLv_AurelionSol
{

    using LeagueSharp;
    using LeagueSharp.Common;

    using System.Collections.Generic;

    internal class SkyLv_AurelionSol
    {

        public static Menu Menu;
        public static Orbwalking.Orbwalker Orbwalker;
        public static Spell Q;
        public static Spell W1;
        public static Spell W2;
        public static Spell E;
        public static Spell R;

        public static List<Spell> SpellList = new List<Spell>();

        public static SpellSlot HealSlot;
        public static SpellSlot BarrierSlot;
        public static SpellSlot CleanseSlot;
        public static SpellSlot IgniteSlot;

        public static Items.Item SeraphsEmbrace = new Items.Item(3040, 0);
        public static Items.Item ZhonyasHourglass = new Items.Item(3157, 0);
        public static Items.Item WoogletsWitchcap = new Items.Item(3090, 0);

        public static Items.Item QuicksilverSash = new Items.Item(3140, 0);
        public static Items.Item MercurialScimitar = new Items.Item(3139, 0);
        public static Items.Item DervishBlade = new Items.Item(3137, 0);
        public static Items.Item MikaelsCrucible = new Items.Item(3222, 750);

        public static List<Obj_AI_Hero> Enemies = new List<Obj_AI_Hero>(), Allies = new List<Obj_AI_Hero>();

        public const string ChampionName = "AurelionSol";

        public static Obj_AI_Hero Player
        {
            get
            {
                return ObjectManager.Player;
            }
        }

        public SkyLv_AurelionSol()
        {

            if (Player.ChampionName != ChampionName) return;

            Q = new Spell(SpellSlot.Q, 650f);
            W1 = new Spell(SpellSlot.W, 350f);
            W2 = new Spell(SpellSlot.W, 600f);
            E = new Spell(SpellSlot.E, 400f);
            R = new Spell(SpellSlot.R, 1420f);

            Q.SetSkillshot(0.25f, 180, 850, false, SkillshotType.SkillshotLine);
            R.SetSkillshot(0.25f, 300, 4500, false, SkillshotType.SkillshotLine);


            HealSlot = Player.GetSpellSlot("SummonerHeal");
            BarrierSlot = Player.GetSpellSlot("SummonerBarrier");
            CleanseSlot = Player.GetSpellSlot("SummonerBoost");
            IgniteSlot = Player.GetSpellSlot("Summonerdot");

            SpellList.Add(Q);
            SpellList.Add(W1);
            SpellList.Add(W2);
            SpellList.Add(E);
            SpellList.Add(R);

            Menu = new Menu("SkyLv " + ChampionName + " By LuNi", "SkyLv " + ChampionName + " By LuNi", true);

            Menu.AddSubMenu(new Menu("Orbwalking", "Orbwalking"));

            var targetSelectorMenu = new Menu("Target Selector", "Target Selector");
            TargetSelector.AddToMenu(targetSelectorMenu);
            Menu.AddSubMenu(targetSelectorMenu);

            Orbwalker = new Orbwalking.Orbwalker(Menu.SubMenu("Orbwalking"));

            Menu.AddSubMenu(new Menu("Combo", "Combo"));

            Menu.AddSubMenu(new Menu("Harass", "Harass"));

            Menu.AddSubMenu(new Menu("LaneClear", "LaneClear"));

            Menu.AddSubMenu(new Menu("JungleClear", "JungleClear"));

            Menu.AddSubMenu(new Menu("Misc", "Misc"));

            Menu.AddSubMenu(new Menu("Drawings", "Drawings"));

            Menu.AddToMainMenu();

            new KillSteal();
            new AntiGapCLoser();
            new JungleSteal();
            new Interrupter();
            new AAManager();
            new OnUpdateFeatures();
            new CastOnDash();
            new Activators();
            new Combo();
            new Harass();
            new JungleClear();
            new LaneClear();
            new PotionManager();
            new SpellLeveler();
            new Draw();
            new SkinChanger();
            new FountainMoves();
        }
    }
}