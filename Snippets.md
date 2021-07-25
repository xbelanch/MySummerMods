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
```

You can easily translate this to the other lights of the house.

// TODO: How to emulate the switch being pressed.

## Switch on the TV

``` c#
GameObject.Find("YARD/Building/LIVINGROOM/TV/Switch").GetComponent<PlayMakerFSM>().FsmVariables.FindFsmBool("Open").Value = true;
```
