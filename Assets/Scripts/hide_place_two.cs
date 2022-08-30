using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_place_two : MonoBehaviour
{
    public GameObject Ui_E;
    public GameObject hero;

    private bool permission_hide = false;

    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E) && (permission_hide) && (state)))
        {
            hero.SetActive(false);
            Ui_E.SetActive(true);
            state = false;
            permission_hide = true;
        }   
        else if ((Input.GetKeyDown(KeyCode.E) && (permission_hide) && (!state)))
        {
            hero.SetActive(true);
            Ui_E.SetActive(true);
            state = true;
        }    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Ui_E.SetActive(true);
        permission_hide = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        Ui_E.SetActive(false);
        permission_hide = false;
    }
}
