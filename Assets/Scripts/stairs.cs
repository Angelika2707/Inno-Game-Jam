using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class stairs : MonoBehaviour
{
    public GameObject main_hero;
    private bool permission_to_change_speed = true;

    private void OnTriggerEnter2D(Collider2D hero)
    {
        if (permission_to_change_speed)
            main_hero.GetComponent<Hero_Interaction>().speed_horizontal = 0;
        permission_to_change_speed = false;
    }
}
