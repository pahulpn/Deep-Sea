using UnityEngine;

public class SubCollision : MonoBehaviour {
    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {
       

        if (col.gameObject.tag == "Spiky") {
            Health.health = Health.health - 25;
        }
        if (col.gameObject.tag == "Rock")
        {
            Health.health = Health.health - 10;
        }
        if (col.gameObject.tag == "Shark")
        {
            Health.health = 0;
        }
         
    }
    }

