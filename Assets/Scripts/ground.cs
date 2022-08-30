using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject main_hero;

    private void OnTriggerEnter2D(Collider2D hero)
    {
        main_hero.GetComponent<Hero_Interaction>().speed_horizontal = 2;
        main_hero.GetComponent<Hero_Interaction>().speed_vertical = 0;
    }
}
