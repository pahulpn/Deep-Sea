using UnityEngine;
using System.Collections;

public class Shark : MonoBehaviour {
    public GameObject shark;
    public int moveSpeed;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<CharacterController>().Move(shark.transform.right * Time.deltaTime * moveSpeed);

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Rock")
        {
            
            Quaternion newDirection = Random.rotation;
            shark.transform.localRotation = newDirection;
        }
        if (col.gameObject.tag == "Torpedo")
        {
            Destroy(this);
        }
    }
}
