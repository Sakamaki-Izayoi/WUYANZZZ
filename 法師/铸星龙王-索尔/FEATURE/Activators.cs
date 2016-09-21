namespace SkyLv_AurelionSol
{
    using System;
    using System.Linq;

    using LeagueSharp;
    using LeagueSharp.Common;


    internal class Activators
    {
        #region #GET
        private static Obj_AI_Hero Player
        {
            get
            {
                return SkyLv_AurelionSol.Player;
            }
        }
        #endregion


        static Activators()
        {
            //Menu
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddSubMenu(new Menu("Items Activator", "Items Activator"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddItem(new MenuItem("AurelionSol.Activator", "Use Activator").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddItem(new MenuItem("AurelionSol.ActivatorActive", "Activator Key Press!").SetValue(new KeyBind(32, KeyBindType.Press)));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddItem(new MenuItem("AurelionSol.ActivatorActiveToggle", "Activator Key Toggle!").SetValue(new KeyBind("U".ToCharArray()[0], KeyBindType.Toggle, true)));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddSubMenu(new Menu("Purifiers Menu", "Purifiers Menu"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyBlind", "Purify Blind").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyCharm", "Purify Charm").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyFear", "Purify Fear").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyFlee", "Purify Flee").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifySnare", "Purify Snare").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyTaunt", "Purify Taunt").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifySupression", "Purify Supression").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyStun", "Purify Stun").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyPolymorph", "Purify Polymorph").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifySilence", "Purify Silence").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyDehancer", "Purify Dehancer").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyZedUltimate", "Purify Zed Ultimate").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyExhaust", "Purify Exhaust").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddItem(new MenuItem("AurelionSol.PurifyIgnite", "Purify Ignite").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").AddSubMenu(new Menu("Purifiers Items / Spells", "Purifiers Items / Spells"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").SubMenu("Purifiers Items / Spells").AddItem(new MenuItem("AurelionSol.useCleanse", "Use Cleanse / Summoner Spell").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").SubMenu("Purifiers Items / Spells").AddItem(new MenuItem("AurelionSol.useQuicksilverSash", "Use Quicksilver Sash").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").SubMenu("Purifiers Items / Spells").AddItem(new MenuItem("AurelionSol.useMercurialScimitar", "Use Mercurial Scimitar").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").SubMenu("Purifiers Items / Spells").AddItem(new MenuItem("AurelionSol.useMikaelsCrucible", "Use Mikael's Crucible").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Purifiers Menu").SubMenu("Purifiers Items / Spells").AddItem(new MenuItem("AurelionSol.useDervishBlade", "Use Dervish Blade").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddSubMenu(new Menu("Use Seraph's Embrace", "Use Seraph's Embrace"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Use Seraph's Embrace").AddItem(new MenuItem("Cassiopeia.AutoSeraphsEmbrace", "Auto Seraph Usage").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Use Seraph's Embrace").AddItem(new MenuItem("Cassiopeia.AutoSeraphsEmbraceMiniHP", "Minimum Health Percent To Use Auto Seraph").SetValue(new Slider(30, 0, 100)));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddSubMenu(new Menu("Use Zhonya's Hourglass", "Use Zhonya's Hourglass"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Use Zhonya's Hourglass").AddItem(new MenuItem("Cassiopeia.useZhonyasHourglass", "Use Zhonya's Hourglass").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Use Zhonya's Hourglass").AddItem(new MenuItem("Cassiopeia.MinimumHPtoZhonyasHourglass", "Minimum Health Percent To Use Zhonya's Hourglass").SetValue(new Slider(30, 0, 100)));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").AddSubMenu(new Menu("Use Wooglet's Witchcap", "Use Wooglet's Witchcap"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Use Wooglet's Witchcap").AddItem(new MenuItem("Cassiopeia.useWoogletsWitchcap", "Use Wooglet's Witchcap").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("Items Activator").SubMenu("Use Wooglet's Witchcap").AddItem(new MenuItem("Cassiopeia.MinimumHPtoWoogletsWitchcap", "Minimum Health Percent To Use Wooglet's Witchcap").SetValue(new Slider(30, 0, 100)));

            SkyLv_AurelionSol.Menu.SubMenu("Misc").AddSubMenu(new Menu("Auto Summoner Spell Usage", "Auto Summoner Spell Usage"));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Auto Summoner Spell Usage").AddSubMenu(new Menu("Use Heal", "Use Heal"));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Auto Summoner Spell Usage").SubMenu("Use Heal").AddItem(new MenuItem("AurelionSol.UseHeal", "Use Heal").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Auto Summoner Spell Usage").SubMenu("Use Heal").AddItem(new MenuItem("AurelionSol.MinimumHPtoHeal", "Minimum Health Percent To Use Heal").SetValue(new Slider(30, 0, 100)));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Auto Summoner Spell Usage").AddSubMenu(new Menu("Use Barriere", "Use Barrier"));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Auto Summoner Spell Usage").SubMenu("Use Barrier").AddItem(new MenuItem("AurelionSol.UseBarrier", "Use Barrier").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Auto Summoner Spell Usage").SubMenu("Use Barrier").AddItem(new MenuItem("AurelionSol.MinimumHPtoBarrier", "Minimum Health Percent To Use Barrier").SetValue(new Slider(30, 0, 100)));

            Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast;
        }

        #region Interupt OnProcessSpellCast
        public static void Obj_AI_Base_OnProcessSpellCast(Obj_AI_Base unit, GameObjectProcessSpellCastEventArgs args)
        {
            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.Activator").GetValue<bool>() && (SkyLv_AurelionSol.Menu.Item("AurelionSol.ActivatorActive").GetValue<KeyBind>().Active || SkyLv_AurelionSol.Menu.Item("AurelionSol.ActivatorActiveToggle").GetValue<KeyBind>().Active))
            {
                if (SkyLv_AurelionSol.Menu.Item("AurelionSol.AutoSeraphsEmbrace").GetValue<bool>() && SkyLv_AurelionSol.SeraphsEmbrace.IsReady() && Player.HealthPercent <= SkyLv_AurelionSol.Menu.Item("AurelionSol.AutoSeraphsEmbraceMiniHP").GetValue<Slider>().Value && (unit.IsValid<Obj_AI_Hero>() || unit.IsValid<Obj_AI_Turret>()) && unit.IsEnemy && args.Target.IsMe)
                {
                    SkyLv_AurelionSol.SeraphsEmbrace.Cast();
                    return;
                }

                if ((unit.IsValid<Obj_AI_Hero>() || unit.IsValid<Obj_AI_Turret>()) && unit.IsEnemy && args.Target.IsMe && SkyLv_AurelionSol.Menu.Item("AurelionSol.useZhonyasHourglass").GetValue<bool>() && SkyLv_AurelionSol.ZhonyasHourglass.IsReady() && Player.HealthPercent <= SkyLv_AurelionSol.Menu.Item("AurelionSol.MinimumHPtoZhonyasHourglass").GetValue<Slider>().Value)
                {
                    SkyLv_AurelionSol.ZhonyasHourglass.Cast();
                    return;
                }

                if ((unit.IsValid<Obj_AI_Hero>() || unit.IsValid<Obj_AI_Turret>()) && unit.IsEnemy && args.Target.IsMe && SkyLv_AurelionSol.Menu.Item("AurelionSol.useWoogletsWitchcap").GetValue<bool>() && SkyLv_AurelionSol.WoogletsWitchcap.IsReady() && Player.HealthPercent <= SkyLv_AurelionSol.Menu.Item("AurelionSol.MinimumHPtoWoogletsWitchcap").GetValue<Slider>().Value)
                {
                    SkyLv_AurelionSol.WoogletsWitchcap.Cast();
                    return;
                }
            }

            #region Summoner Spell Usage
            if ((unit.IsValid<Obj_AI_Hero>() || unit.IsValid<Obj_AI_Turret>()) && unit.IsEnemy)
            {
                if (args.Target.IsMe && SkyLv_AurelionSol.Menu.Item("AurelionSol.UseHeal").GetValue<bool>() && SkyLv_AurelionSol.HealSlot.IsReady() && Player.HealthPercent <= SkyLv_AurelionSol.Menu.Item("AurelionSol.MinimumHPtoHeal").GetValue<Slider>().Value)
                {
                    Player.Spellbook.CastSpell(SkyLv_AurelionSol.HealSlot);
                    return;
                }

                if (args.Target.IsMe && SkyLv_AurelionSol.Menu.Item("AurelionSol.UseBarrier").GetValue<bool>() && SkyLv_AurelionSol.BarrierSlot.IsReady() && Player.HealthPercent <= SkyLv_AurelionSol.Menu.Item("AurelionSol.MinimumHPtoBarrier").GetValue<Slider>().Value)
                {
                    Player.Spellbook.CastSpell(SkyLv_AurelionSol.BarrierSlot);
                    return;
                }
            }
            #endregion

        }
        #endregion

        #region Purifiers
        public static void Purifiers()
        {

            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.useQuicksilverSash").GetValue<bool>() && SkyLv_AurelionSol.QuicksilverSash.IsReady())
            {
                if ((SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyStun").GetValue<bool>() && Player.HasBuffOfType(BuffType.Stun)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySnare").GetValue<bool>() && Player.HasBuffOfType(BuffType.Snare)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyTaunt").GetValue<bool>() && Player.HasBuffOfType(BuffType.Taunt)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyCharm").GetValue<bool>() && Player.HasBuffOfType(BuffType.Charm)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFear").GetValue<bool>() && Player.HasBuffOfType(BuffType.Fear)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyBlind").GetValue<bool>() && Player.HasBuffOfType(BuffType.Blind)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyPolymorph").GetValue<bool>() && Player.HasBuffOfType(BuffType.Polymorph)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFlee").GetValue<bool>() && Player.HasBuffOfType(BuffType.Flee)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySilence").GetValue<bool>() && Player.HasBuffOfType(BuffType.Silence)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySupression").GetValue<bool>() && Player.HasBuffOfType(BuffType.Suppression)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyDehancer").GetValue<bool>() && Player.HasBuffOfType(BuffType.CombatDehancer)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyZedUltimate").GetValue<bool>() && Player.HasBuff("zedultexecute")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyExhaust").GetValue<bool>() && Player.HasBuff("SummonerExhaust")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyIgnite").GetValue<bool>() && Player.HasBuff("SummonerDot")))
                {
                    SkyLv_AurelionSol.QuicksilverSash.Cast();
                    return;
                }
                return;
            }

            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.useMercurialScimitar").GetValue<bool>() && SkyLv_AurelionSol.MercurialScimitar.IsReady())
            {
                if ((SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyStun").GetValue<bool>() && Player.HasBuffOfType(BuffType.Stun)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySnare").GetValue<bool>() && Player.HasBuffOfType(BuffType.Snare)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyTaunt").GetValue<bool>() && Player.HasBuffOfType(BuffType.Taunt)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyCharm").GetValue<bool>() && Player.HasBuffOfType(BuffType.Charm)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFear").GetValue<bool>() && Player.HasBuffOfType(BuffType.Fear)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyBlind").GetValue<bool>() && Player.HasBuffOfType(BuffType.Blind)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyPolymorph").GetValue<bool>() && Player.HasBuffOfType(BuffType.Polymorph)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFlee").GetValue<bool>() && Player.HasBuffOfType(BuffType.Flee)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySilence").GetValue<bool>() && Player.HasBuffOfType(BuffType.Silence)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySupression").GetValue<bool>() && Player.HasBuffOfType(BuffType.Suppression)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyDehancer").GetValue<bool>() && Player.HasBuffOfType(BuffType.CombatDehancer)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyZedUltimate").GetValue<bool>() && Player.HasBuff("zedultexecute")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyExhaust").GetValue<bool>() && Player.HasBuff("SummonerExhaust")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyIgnite").GetValue<bool>() && Player.HasBuff("SummonerDot")))
                {
                    SkyLv_AurelionSol.MercurialScimitar.Cast();
                    return;
                }
                return;
            }

            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.useDervishBlade").GetValue<bool>() && SkyLv_AurelionSol.DervishBlade.IsReady())
            {
                if ((SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyStun").GetValue<bool>() && Player.HasBuffOfType(BuffType.Stun)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySnare").GetValue<bool>() && Player.HasBuffOfType(BuffType.Snare)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyTaunt").GetValue<bool>() && Player.HasBuffOfType(BuffType.Taunt)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyCharm").GetValue<bool>() && Player.HasBuffOfType(BuffType.Charm)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFear").GetValue<bool>() && Player.HasBuffOfType(BuffType.Fear)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyBlind").GetValue<bool>() && Player.HasBuffOfType(BuffType.Blind)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyPolymorph").GetValue<bool>() && Player.HasBuffOfType(BuffType.Polymorph)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFlee").GetValue<bool>() && Player.HasBuffOfType(BuffType.Flee)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySilence").GetValue<bool>() && Player.HasBuffOfType(BuffType.Silence)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySupression").GetValue<bool>() && Player.HasBuffOfType(BuffType.Suppression)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyDehancer").GetValue<bool>() && Player.HasBuffOfType(BuffType.CombatDehancer)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyZedUltimate").GetValue<bool>() && Player.HasBuff("zedultexecute")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyExhaust").GetValue<bool>() && Player.HasBuff("SummonerExhaust")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyIgnite").GetValue<bool>() && Player.HasBuff("SummonerDot")))
                {
                    SkyLv_AurelionSol.DervishBlade.Cast();
                    return;
                }
                return;
            }

            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.useCleanse").GetValue<bool>() && SkyLv_AurelionSol.CleanseSlot.IsReady())
            {
                if ((SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyStun").GetValue<bool>() && Player.HasBuffOfType(BuffType.Stun)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySnare").GetValue<bool>() && Player.HasBuffOfType(BuffType.Snare)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyTaunt").GetValue<bool>() && Player.HasBuffOfType(BuffType.Taunt)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyCharm").GetValue<bool>() && Player.HasBuffOfType(BuffType.Charm)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFear").GetValue<bool>() && Player.HasBuffOfType(BuffType.Fear)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyBlind").GetValue<bool>() && Player.HasBuffOfType(BuffType.Blind)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyPolymorph").GetValue<bool>() && Player.HasBuffOfType(BuffType.Polymorph)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFlee").GetValue<bool>() && Player.HasBuffOfType(BuffType.Flee)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySilence").GetValue<bool>() && Player.HasBuffOfType(BuffType.Silence)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySupression").GetValue<bool>() && Player.HasBuffOfType(BuffType.Suppression)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyDehancer").GetValue<bool>() && Player.HasBuffOfType(BuffType.CombatDehancer)) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyZedUltimate").GetValue<bool>() && Player.HasBuff("zedultexecute")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyExhaust").GetValue<bool>() && Player.HasBuff("SummonerExhaust")) ||
                   (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyIgnite").GetValue<bool>() && Player.HasBuff("SummonerDot")))
                {
                    Player.Spellbook.CastSpell(SkyLv_AurelionSol.CleanseSlot);
                    return;
                }
                return;
            }

            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.useMikaelsCrucible").GetValue<bool>() && SkyLv_AurelionSol.MikaelsCrucible.IsReady())
            {
                foreach (var AlliesTarget in ObjectManager.Get<Obj_AI_Hero>().Where(target => !target.IsMe && target.Team == ObjectManager.Player.Team && Player.Distance(target) <= SkyLv_AurelionSol.MikaelsCrucible.Range))
                {
                    if ((SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyStun").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Stun)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySnare").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Snare)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyTaunt").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Taunt)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyCharm").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Charm)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFear").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Fear)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyBlind").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Blind)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyPolymorph").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Polymorph)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyFlee").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Flee)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySilence").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Silence)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifySupression").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.Suppression)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyDehancer").GetValue<bool>() && AlliesTarget.HasBuffOfType(BuffType.CombatDehancer)) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyZedUltimate").GetValue<bool>() && AlliesTarget.HasBuff("zedultexecute")) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyExhaust").GetValue<bool>() && AlliesTarget.HasBuff("SummonerExhaust")) ||
                       (SkyLv_AurelionSol.Menu.Item("AurelionSol.PurifyIgnite").GetValue<bool>() && AlliesTarget.HasBuff("SummonerDot")))
                    {

                        SkyLv_AurelionSol.MikaelsCrucible.Cast(AlliesTarget);
                        return;

                    }
                    return;
                }
                return;
            }
        }
        #endregion
    }
}
