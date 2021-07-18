using MSCLoader;
using UnityEngine;
// using UnityEngine.UI;
using HutongGames.PlayMaker;
using System.IO;

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
        public bool UseAssetsFolder => true;


        private GameObject clock;
        private GameObject clockMesh;
        private GameObject clockData;
        

        //private uint hour;
        //private double minutes;

        //private FsmFloat globalTime;
        //private FsmFloat minutes;
        //private FsmFloat hours;


        private FsmBool isGameLoaded = false;


        private Animation _doorAnimation;
        private FsmBool _handleDoor;
        private FsmFloat _clockMinutes;


        public override void OnNewGame()
        {
            // Called once, when starting a New Game, you can reset your saves here
            ModConsole.Log("OnNewGame()");
        }

        public override void OnLoad()
        {
            // Called once, when mod is loading after game is fully loaded
            ModConsole.Log("Clock mod has loaded.");

            _clockMinutes = FsmVariables.GlobalVariables.FindFsmFloat("ClockMinutes");
            // string logHours = "Clock Hours: " + clockHours;
            // string logMinutes = "Clock Minutes: " + clockMinutes;


            // Bedroom door open animation at start of game
            _doorAnimation = GameObject.Find("YARD/Building/BEDROOM1/DoorBedroom1/Pivot").GetComponent<Animation>();
            _doorAnimation.Play("door_white_open");
            _handleDoor = GameObject.Find("YARD/Building/BEDROOM1/DoorBedroom1/Pivot/Handle").GetComponent<PlayMakerFSM>().FsmVariables.FindFsmBool("DoorOpen");
            // Fix door open/close state 
            ModConsole.Log("_handleDoor: " + _handleDoor);
            _handleDoor.Value = true;
            ModConsole.Log("_handleDoor: " + _handleDoor);


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
            //int t = (int)_clockMinutes;
            //if (t % 10 == 0) {
            //    ModConsole.Log("Is it working?");
            //    if (_isDoorOpen.Value == true)
            //    {
            //        _isDoorOpen = false;
            //    } else
            //    {
            //        _isDoorOpen = true;
            //    }
            //}
            
        }
    }
}
