using UnityEngine;
using UnityEngine.EventSystems;
using Infra.Gameplay.UI;

namespace BatCave {
/// <summary>
/// A base class that allows to get input for the bat.
/// </summary>
[CreateAssetMenu(menuName = "Bat Controller/Mouse")]
public class BatMouseController : BatController {
	private bool FlyUp;

    /// <summary>
    /// Returns true if spacebar is down
    /// </summary>
	public override bool WantsToFlyUp ()
	{
		return FlyUp;
	}

	public void OnEnable()
    {
		GameInputCapture.OnTouchDown += OnTouchDown;
        GameInputCapture.OnTouchUp += OnTouchUp;  
    }

    public void OnDisable()
    {
		GameInputCapture.OnTouchDown -= OnTouchDown;
        GameInputCapture.OnTouchUp -= OnTouchUp;
    }

	private void OnTouchDown(PointerEventData e) {
		if (e.used) return;
        FlyUp = true;
    }

    private void OnTouchUp(PointerEventData e) {
        FlyUp = false;
    }
}
}