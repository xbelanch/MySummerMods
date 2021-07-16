using MSCLoader;
using UnityEngine;
using HutongGames.PlayMaker;

namespace Clock
{
    public class Clock : Mod
    {
        public override string ID => "Clock"; //Your mod ID (unique)
        public override string Name => "Clock"; //You mod name
        public override string Author => "Xavier Belanche"; //Your Username
        public override string Version => "1.0"; //Version

        // Set this to true if you will be load custom assets from Assets folder.
        // This will create subfolder in Assets folder for your mod.
        // public override bool UseAssetsFolder => false;

        public override void OnNewGame()
        {
            // Called once, when starting a New Game, you can reset your saves here
            ModConsole.Log("OnNewGame()");
        }

        public override void OnLoad()
        {
            // Called once, when mod is loading after game is fully loaded
            ModConsole.Log("Clock mod has loaded.");
        }

        public override void ModSettings()
        {
            // All settings should be created here. 
            // DO NOT put anything else here that settings.
        }

        public override void OnSave()
        {
            // Called once, when save and quit
            // Serialize your save file here.
        }

        public override void OnGUI()
        {
            // Draw unity OnGUI() here           
        }

        public override void Update()
        {
            // Update is called once per frame
        }
    }
}
