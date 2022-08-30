using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameplay : MonoBehaviour
{
    public GameObject dialog_window;
    public TextMeshProUGUI change_text;
    public GameObject run_text;

    public GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D col)
    {
        dialog_window.SetActive(true);
        hero.GetComponent<Hero_Interaction>().speed_vertical = 0;
        hero.GetComponent<Hero_Interaction>().speed_horizontal = 0;
        Hero_Interaction.anim.SetInteger("state", 1);
        StartCoroutine(Dialog());
    }
    
    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(2);
        change_text.text = "son: D-dad, M-mom... please stop ";
        yield return new WaitForSeconds(2);
        change_text.text = "Dad: SHUT UP!";
        yield return new WaitForSeconds(2);
        dialog_window.SetActive(false);
        run_text.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        run_text.SetActive(false);
        hero.GetComponent<Hero_Interaction>().speed_horizontal = 2;
    }
}
