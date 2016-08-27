using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TorpedoFireButton : MonoBehaviour, IPointerDownHandler {

    public SubmarineController subController;
    public void OnPointerDown(PointerEventData pointerData) {
        if (Health.health != 0)
        {
            subController.FireTorpedo();
        }
    }

}
