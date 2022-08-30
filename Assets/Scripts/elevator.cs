using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elevator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rectangle;
    public GameObject Ui_e;
    private SpriteRenderer color_rectangle;
    public float speed;
    private bool end = false;
    private bool end2 = false;

    private void Start()
    {
        color_rectangle = rectangle.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            end2 = true;
        if ((end) && (end2))
        {
            color_rectangle.color = new Color(color_rectangle.color.r, color_rectangle.color.g, color_rectangle.color.b,
                color_rectangle.color.a + speed);
            Invoke("change_scene", 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Ui_e.SetActive(true);
        end = true;
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        Ui_e.SetActive(false);
        end = false;
    }

    void change_scene()
    {
        SceneManager.LoadScene("main_part");
    }
}
