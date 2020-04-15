using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSensitivity = 100f;

    //Position, rotation and scale of an object.
    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
        // THis will hide the mouse pointer in game
        //if (SceneManager.GetActiveScene().Equals(1) || PauseMenu.GameIsPaused == false)
        //{
           // Cursor.lockState = CursorLockMode.Locked;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        // makes sure when a player has a higher framerate it will not rotate quicker if the framerate is low
        //Time.deltaTime is the Time that has gone by since the last time the update function was called
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


        //o.g.: xRotation += mouseY, but it flipped the mouse movement along the axis
        xRotation -= mouseY;

        //allows only 90 degree rotation along y axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Quaternion is resposnible for rotation in unity
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //allows you to look around without moving the player body
        playerBody.Rotate(Vector3.up * mouseX);



    }
}
