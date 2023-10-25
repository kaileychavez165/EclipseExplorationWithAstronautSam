using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MainCamera : MonoBehaviour
{
    //code to control the camera independent of the character but following the character
    //adds a field to the main camera where the player's transform can be used
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        //makes the transform of the camera get x and y positions of the player. z is still the cameras z
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
