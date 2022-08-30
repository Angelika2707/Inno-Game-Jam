using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_place : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject E_ui;
    public GameObject photo;
    public Sprite sprite_room;
    public Sprite sprite_room2;
    private bool permission_hide = false;
    public GameObject main_hero;
    private bool hide = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((permission_hide) && (Input.GetKeyDown(KeyCode.E)) && (hide))
        {
            photo.GetComponent<SpriteRenderer>().sprite = sprite_room;
            main_hero.SetActive(false);
            E_ui.SetActive(true);
            hide = false;
            permission_hide = true;
        }
        else if ((Input.GetKeyDown(KeyCode.E) && (!hide)))
        {
            photo.GetComponent<SpriteRenderer>().sprite = sprite_room2;
            main_hero.SetActive(true);
            E_ui.SetActive(true);
            hide = true;
        }    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        E_ui.SetActive(true);
        permission_hide = true;
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        E_ui.SetActive(false);
        permission_hide = false;
    }
}
