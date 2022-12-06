using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   // Declare prefab as GameObject
   public GameObject spherePrefab;

   void Update(){
    if (Input.GetKeyDown(KeyCode.Q)){
        // "instance" = Instansiation of prefab. //transform.position = new position for obect to start at. //Quaternion.identity = no rotation of the object
        var instance = Instantiate(spherePrefab, transform.position, Quaternion.identity);
        // Gets the Rigidbody Component of the "instance" of the Game Object and Adds Force to It
        instance.GetComponent<Rigidbody>().AddForce(transform.forward * 1000, ForceMode.Acceleration);
    }
   }
}
