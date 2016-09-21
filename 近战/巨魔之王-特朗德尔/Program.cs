namespace ElTrundle
{
    using LeagueSharp.Common;

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Trundle.OnLoad;
        }

        #endregion
    }
}