using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubmarineController : MonoBehaviour {

    public float moveSpeed = 10;
    public float rotateSpeed = 10;
   
    public GameObject submarine;
    public Camera gvrCamera;
    public GameObject torpedoPrefab;
    //public Canvas canvas;
    //public static Slider slider;
    //public static GvrHead head;

    public Transform leftFirePosition;
    public Transform rightFirePosition;
    public Transform convergencePoint;

    private bool fireLeftTorpedo = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        UpdateRotation();
        if (Health.health != 0)
        {
            UpdateMovement();
        }
	}

    void UpdateRotation () {
        Quaternion cameraLookRotation = Quaternion.LookRotation(gvrCamera.transform.forward, gvrCamera.transform.up);
        submarine.transform.localRotation = Quaternion.RotateTowards(submarine.transform.rotation, cameraLookRotation, rotateSpeed * Time.deltaTime);
        
    }
    void UpdateMovement() {
        GetComponent<CharacterController>().Move(submarine.transform.forward * Time.deltaTime * moveSpeed);
    }
    
    public void FireTorpedo() {
        Vector3 torpedoFirePosition;
        if (fireLeftTorpedo) {
            torpedoFirePosition = leftFirePosition.position;
            fireLeftTorpedo = false;
        }
        else {
            torpedoFirePosition = rightFirePosition.position;
            fireLeftTorpedo = true;
        }


        GameObject torpedoObject = Instantiate(torpedoPrefab, torpedoFirePosition, Quaternion.identity) as GameObject;
        torpedoObject.transform.forward = (convergencePoint.position - torpedoObject.transform.position).normalized;

    }
}
