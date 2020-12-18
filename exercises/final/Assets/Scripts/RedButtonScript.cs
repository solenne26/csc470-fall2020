using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RedButtonScript : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Debug.Log("Detected hover");
        GameManager.instance.Text.text = "This button needs 3 clues to be unlocked.";
        GameManager.instance.Panel.SetActive(true);

    }

    private void OnMouseExit()
    {
        GameManager.instance.Text.text = " ";
        GameManager.instance.Panel.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("Detected click");

        if (GameManager.instance.CluesCollected == GameManager.instance.MaxClues)
        {
            SceneManager.LoadScene("stage2");
            Debug.Log("Found all clues");
        }
    }
}
