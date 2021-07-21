using MSCLoader;
using UnityEngine;
// using UnityEngine.UI;
using HutongGames.PlayMaker;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

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

        private GameObject _sun;
        private FsmFloat _rot;
        private Transform _transH, _transM;

        /// <summary>
        /// Hour in day, 0 to 12 float.
        /// </summary>
        private float Hour12F => ((360.0f - _transH.localRotation.eulerAngles.y) / 30.0f + 2.0f) % 12;
        private void log(string message) {
            ModConsole.Log(message);
        }

        public override void OnNewGame()
        {
            // Called once, when starting a New Game, you can reset your saves here

        }

        public override void OnLoad()
        {
            // Called once, when mod is loading after game is fully loaded
            // This code belongs to @Wampa842
            // src: https://github.com/Wampa842/MySummerMods/blob/d2147b3cb28af8b0873ff0637f6e4de53e8d0dc2/TwentyFourClock/Clock24.cs
            _sun = GameObject.Find("SUN/Pivot");
            _rot = _sun.GetComponent<PlayMakerFSM>().FsmVariables.FindFsmFloat("Rotation");

            _transH = GameObject.Find("SuomiClock/Clock/hour/NeedleHour").transform;
            _transM = GameObject.Find("SuomiClock/Clock/minute/NeedleMinute").transform;

            ModConsole.Log("Hour12F: " + Hour12F);

            // Switch bedroom light on
            // GameObject _switchBedroom =
            // GameObject.Find("YARD/Building/Dynamics/LightSwitches/switch_bedroom2").SetActive(true);

            // NOT Working
            GameObject _obj = GameObject.Find("YARD/Building/Dynamics/LightSwitches/switch_bedroom2");
            // ModConsole.Log("_obj: " + _obj);
            PlayMakerFSM _objFsm = _obj.GetComponent<PlayMakerFSM>();
            // ModConsole.Log("_objFsm: " + _objFsm.ToString());     
            foreach (var state in _objFsm.FsmStates)
            {
                //ModConsole.Log("state: " + state.ToString());

                foreach (var action in state.Actions)
                {
                    // ModConsole.Log("action: " + action.ToString());
                }


            }
            var _action = _obj.GetComponent<PlayMakerFSM>().FsmStates[0].Actions;
            var _firstAction = _action.First<FsmStateAction>();
            var _typename = _firstAction.GetType().ToString();
            _typename = _typename.Substring(_typename.LastIndexOf(".", StringComparison.Ordinal) + 1);
            log("inspect _typename action: " + _typename);
            var _fields = _firstAction.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (var fieldInfo in _fields)
            {
                try
                {
                    var _fieldValue = fieldInfo.GetValue(_firstAction);
                    _fieldValue = true;
                    var _fieldValueStr = _fieldValue.ToString();
                    _fieldValueStr = _fieldValueStr.Substring(_fieldValueStr.LastIndexOf(".", System.StringComparison.Ordinal) + 1);
                    log("field: " + fieldInfo.Name + " _field value: " + _fieldValueStr);
                }   
                catch (Exception)
                {

                }   
            }           

                    // First(x => x.Name == "activate").Enabled = true;
                    // string _wtf = _obj.GetComponent<PlayMakerFSM>().FsmStates.First().ToString();     
                    // if (e.name == "Hand")
                    // {
                    //     PlayMakerFSM fsmHand = e;
                    //     GameObject item = fsmHand.FsmVariables.GetFsmGameObject("PickedObject").Value;
                    //     item.transform.parent = GameObject.Find("FPSCamera").transform;
                    //     item.GetComponent<Rigidbody>();
                    //     var rb = item.GetComponent<Rigidbody>();
                    //     rb.isKinematic = true;
                    //     rb.useGravity = false;

                    //     return item;
                    // }



                    // PlayMakerFSM _switchBedroom = GameObject.Find("YARD/Building/Dynamics/LightSwitches/switch_bedroom2").GetComponent<PlayMakerFSM>();
                    // FsmBool _lightON = _switchBedroom.FsmVariables.FindFsmBool("Switch");
                    // ModConsole.Log("_switchkitchen status: " + _lightON);
                    // string _wtf = _switchBedroom.FsmStates.GetValue(8).ToString();
                    // ModConsole.Log("_wtf? " + _wtf);
                    // _lightON = true;
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
