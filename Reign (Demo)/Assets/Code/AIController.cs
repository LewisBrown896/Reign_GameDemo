using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIController : MonoBehaviour
{
    public Transform player;
    static Animator anim;

    public Slider healthbar;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (heathbar.value <= 0) return;
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 30 && angle < 30) // if player is in a distance of 10 of the enemy
        {
            
            direction.y = 0; //skeleton doesnt follow on the y axis

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f); //turns entire body to look at player

            anim.SetBool("isIdle", false); //IDle animation false when in range of player

            //follows player along x and z axis
            if (direction.magnitude > 5) //if play is in range of enemy
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("walking", true); //walking animation on
                anim.SetBool("attacking", false); //attack animation off
            }
            else //player is next to from enemy
            {
                anim.SetBool("attacking", true);
                anim.SetBool("walking", false);
            }
        }
        else // player not in distance of enemy
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("walking", false);
            anim.SetBool("attacking", false);
        }
        
    }
}
