using MSCLoader;
using UnityEngine;
using HutongGames.PlayMaker;
using System;


namespace Sandbox
{
    public class Sandbox : Mod
    {
        public override string ID => "Sandbox"; //Your mod ID (unique)
        public override string Name => "Sandbox"; //You mod name
        public override string Author => "Xavier Belanche"; //Your Username
        public override string Version => "1.0"; //Version

        // Set this to true if you will be load custom assets from Assets folder.
        // This will create subfolder in Assets folder for your mod.
        public bool UseAssetsFolder => true;

        public override void OnNewGame()
        {
            // Called once, when starting a New Game, you can reset your saves here
        }

        public override void OnLoad()
        {
            // Called once, when mod is loading after game is fully loaded
            // Bedroom light or set color to red ;)
            GameObject _lightBedroom2 = GameObject.Find("YARD/Building/Dynamics/HouseElectricity/ElectricAppliances/Bedroom2/LightBedroom2");
            _lightBedroom2.GetComponent<Light>().enabled = true;
            _lightBedroom2.GetComponent<Light>().color = new Color { r = 1, b = 0, g = 0, a = 0.5f };

            // Switch on the red light
            // From: https://www.reddit.com/r/MySummerCar/comments/opq2xt/switch_on_the_bedroom_light/
            GameObject _electricLightBedroom2 = GameObject.Find("YARD/Building/Dynamics/HouseElectricity/ElectricAppliances/Bedroom2");
            _electricLightBedroom2.SetActive(true);

            // Switch on the TV
            GameObject.Find("YARD/Building/LIVINGROOM/TV/Switch").GetComponent<PlayMakerFSM>().FsmVariables.FindFsmBool("Open").Value = true;


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
