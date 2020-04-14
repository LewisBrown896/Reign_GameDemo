using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmor : MonoBehaviour
{
    //maxArmor is set to 100
    public int maxArmor = 100;
    public int currentArmor;

    public ArmorBar armorBar;

    // Start is called before the first frame update
    void Start()
    {
        currentArmor = maxArmor;
        armorBar.SetMaxArmor(maxArmor);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // on left mouse click take armor damage -20
        {
            TakeDamage(20);
        }
    }

    //each time left click is pressed the amount of armor goes down
    //basic armor calculator
    //will be replaced when enemies are added
    void TakeDamage(int damage)
    {
        currentArmor -= damage;

        armorBar.SetArmor(currentArmor);
    }
}
