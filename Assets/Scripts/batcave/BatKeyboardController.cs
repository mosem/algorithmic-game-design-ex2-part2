using UnityEngine;

namespace BatCave {
/// <summary>
/// A base class that allows to get input for the bat.
/// </summary>
[CreateAssetMenu(menuName = "Bat Controller/Keyboard")]
public class BatKeyboardController : BatController {
    /// <summary>
    /// Returns true if spacebar is down
    /// </summary>
	public override bool WantsToFlyUp () {
		
		if (Input.GetKey ("space")) {
			return true;
		}
		return false;
	
	}

	public void Awake()
    {
        Debug.Log("Keyboard.Awake");
    }

    public void OnDestroy()
    {
        Debug.Log("Keyboard.OnDestroy");
    }
}
}