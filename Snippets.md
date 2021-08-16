# Snippets

## Remove a door or any obhect of the game

``` c#
// Why if we want to remove all the doors from house?
GameObject _doorWC = GameObject.Find("YARD/Building/LIVINGROOM/DoorWC");
GameObject.Destroy(_doorWC);
```
## Open or close a selected door

``` c#
// Bedroom door open animation at start of game
_doorAnimation = GameObject.Find("YARD/Building/BEDROOM1/DoorBedroom1/Pivot").GetComponent<Animation>();
_doorAnimation.Play("door_white_open");
_handleDoor = GameObject.Find("YARD/Building/BEDROOM1/DoorBedroom1/Pivot/Handle").GetComponent<PlayMakerFSM>().FsmVariables.FindFsmBool("DoorOpen");
// Fix door open/close state
ModConsole.Log("_handleDoor: " + _handleDoor);
_handleDoor.Value = true;
ModConsole.Log("_handleDoor: " + _handleDoor);
```
## Switch on the lights

Thanks to [OneSidedDie](https://www.reddit.com/user/OneSidedDie/) for the [solution](https://www.reddit.com/r/MySummerCar/comments/opq2xt/switch_on_the_bedroom_light/
).

``` c#
GameObject _electricLightBedroom2 = GameObject.Find("YARD/Building/Dynamics/HouseElectricity/ElectricAppliances/Bedroom2");
            _electricLightBedroom2.SetActive(true);

PlayMakerFSM _switch_bedroom2 = GameObject.Find("YARD/Building/Dynamics/LightSwitches/switch_bedroom2").GetComponent<PlayMakerFSM>();
var _switch = _switch_bedroom2.FsmVariables.GetFsmBool("Switch");
_switch.Value = true; // This fix that light switch off when cursor hover the light switch
```

You can easily translate this to the other lights of the house.

``` c#
GameObject _light_switch_button = GameObject.Find("YARD/Building/Dynamics/LightSwitches/switch_bedroom2/light_switch/light_switch_button");
_light_switch_button.transform.localEulerAngles = new Vector3(348, 0, 0);
```

## Change the color of the light

Called once, when mod is loading after game is fully loaded. Bedroom light or set color to red.

``` c#
GameObject _lightBedroom2 = GameObject.Find("YARD/Building/Dynamics/HouseElectricity/ElectricAppliances/Bedroom2/LightBedroom2");
_lightBedroom2.GetComponent<Light>().enabled = true;
_lightBedroom2.GetComponent<Light>().color = new Color { r = 1, b = 0, g = 0, a = 0.5f };
```

## Switch on/off the TV

``` c#
// Switch on
GameObject.Find("YARD/Building/LIVINGROOM/TV/Switch").GetComponent<PlayMakerFSM>().FsmVariables.FindFsmBool("Open").Value = true;
// Switch off
_switchTV.FsmVariables.FindFsmBool("Open").Value = false;
_switchTV.SendEvent("GLOBALEVENT");

```

## Change text and color of menu buttons

``` c#
public override void MenuOnLoad() {

    GameObject quitButton = Resources.FindObjectsOfTypeAll<GameObject>().First(gobj => gobj.name == "ButtonQuit");
    quitButton.transform.GetChild(0).GetComponent<TextMesh>().text = "Surt";
        quitButton.transform.GetChild(0).GetComponent<MeshRenderer>().materials.First().color = new Color(1f, 0f, 1f, 1f);
    quitButton.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(1f, 0f, 1f, 1f); // Magenta!
    quitButton.transform.GetChild(0).GetChild(0).GetComponent<TextMesh>().text = "Surt";
    quitButton.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials.First().color = new Color(0f, 1f, 0f, 1f);
    quitButton.transform.GetChild(0).GetChild(0).GetComponent<TextMesh>().color = new Color(0f, 1f, 0f, 1f); // Green!

    }
```

## Change MSC Logo

Note: you must put `logo.png` on the assets mod folder.

``` c#
public override void MenuOnLoad()
{
base.MenuOnLoad();

var path = ModLoader.GetModAssetsFolder(this);
Texture2D tLogo = new Texture2D(512, 512);
ModConsole.Log("Path: " + path);
tLogo = ModAssets.LoadTexturePNG(path + "\\logo.png");

// Change official logo for a creeppy new one

GameObject logo = Resources.FindObjectsOfTypeAll<GameObject>().First(gObj => gObj.name == "LOGO");
            logo.transform.localScale = new Vector3(6f, 6f, 6f);
    logo.transform.GetChild(0).GetComponent<MeshRenderer>().materials.First().mainTexture = tLogo;
```

// TODO: Change the main menu scene
