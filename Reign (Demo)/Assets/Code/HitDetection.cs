using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
    // public HealthBar healthBar;

    public Slider healthbar;
    Animator anim;
    public string opponent;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;
        healthbar.value -= 20;
        Debug.Log("Hit");

        if (healthbar.value <= 0)
        {
            SceneManager.LoadScene("Menu");
            anim.SetBool("isDead", true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //TakeDamage(20);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void TakeDamage(int damage)
    //{
    // currentHealth -= damage;
    // healthBar.SetHealth(currentHealth);
   // }
}
