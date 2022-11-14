using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //bool doorIsOpen=false;
   // float doorTimer=0.0f;
   // public float doorOpenTime=3.0f;
   // public AudioClip doorOpenSound;
   // public AudioClip doorShutSound;
    private GameObject currentDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(doorIsOpen){
        //     doorTimer += Time.deltaTime;
        //     if(doorTimer > doorOpenTime){
        //         // ShutDoor(currentDoor);
        //         Door(doorShutSound,doorIsOpen,"doorshut",currentDoor);
        //         doorTimer = 0.0f;
        //     }
        // }
        RaycastHit hit;
        if(Physics.Raycast (transform.position, transform.forward, out hit, 3)) {
            if(hit.collider.gameObject.tag=="playerDoor"){
                currentDoor = hit.collider.gameObject;
                currentDoor.SendMessage("DoorCheck");
            }
        }

    }
    // void OnControllerColliderHit(ControllerColliderHit hit){
    //     if(hit.gameObject.tag=="playerDoor"&& doorIsOpen==false){
    //         currentDoor = hit.gameObject;
    //         // OpenDoor(currentDoor);
    //         Door(doorOpenSound,doorIsOpen,"dooropen",currentDoor);
    //     }

    // }

    // void OpenDoor(GameObject door){
    //     doorIsOpen=true;
    //     door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
    //     door.transform.parent.GetComponent<Animation>().Play("dooropen");

    // }

    // void ShutDoor(GameObject door){
    //     doorIsOpen = false;
    //     door.GetComponent<AudioSource>().PlayOneShot(doorShutSound);
    //     door.transform.parent.GetComponent<Animation>().Play("doorshut");
    // }

    // void Door(AudioClip aClip, bool openCheck, string animName, GameObject thisDoor){
    //     if(openCheck==false){
    //         doorIsOpen=true;
    //     }else
    //     {
    //         doorIsOpen=false;
    //     }
    //     thisDoor.GetComponent<AudioSource>().PlayOneShot(aClip);
    //     thisDoor.transform.parent.GetComponent<Animation>().Play(animName);
    // }

}