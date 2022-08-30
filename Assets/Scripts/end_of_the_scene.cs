using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_of_the_scene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rectangle;
    private SpriteRenderer color_rectangle;
    public float speed;
    private bool permission = false;

    private void Start()
    {
        color_rectangle = rectangle.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (permission)
        {
            color_rectangle.color = new Color(color_rectangle.color.r, color_rectangle.color.g, color_rectangle.color.b,
                color_rectangle.color.a + speed);
            StartCoroutine(Dialog());
        }    
    }

    private void OnTriggerEnter2D(Collider2D hero)
    {
        permission = true;
    }

    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(2);
        Debug.Log('4');
        SceneManager.LoadScene("start scene");
    }
}
