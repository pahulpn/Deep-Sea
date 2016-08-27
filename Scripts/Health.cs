using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {
    public static int health = 100;
    public GameObject sub;
    public Slider healthBar;
	// Use this for initialization
	void Start () {
	
	}
    
	
	// Update is called once per frame
	void Update () {
        healthBar.value = health;
        
	
	}
}
