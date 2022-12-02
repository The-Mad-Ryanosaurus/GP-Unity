using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   public Rigidbody spherePrefab;

   void Update(){
    if (Input.GetKeyDown(KeyCode.Q)){
        Instantiate(spherePrefab, transform.position, Quaternion.identity);
        spherePrefab.AddForce(-transform.forward * 10, ForceMode.Acceleration);
    }
   }
}
