using UnityEngine;
using System.Collections;

//This Code is meant for my original maze game created in 2015
//This Code includes the behavior of crystals that may need to be collected from users

public class CrystalBehavior : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        switch(collider.gameObject.name)
        {
            case "Player":
                
                CrystalController.crystalCount++;
                
                Destroy(this.gameObject);
                
                break;
         }
         
     }
     
}
