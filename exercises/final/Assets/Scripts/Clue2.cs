using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue2 : MonoBehaviour
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
        GameManager.instance.Text.text = "This appears to be a book. Could be useful.";
        GameManager.instance.Panel.SetActive(true);

    }

    private void OnMouseExit()
    {
        GameManager.instance.Text.text = " ";
        GameManager.instance.Panel.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameManager.instance.CluesCollected += 1;
        Destroy(this.gameObject);
        GameManager.instance.Text.text = " ";
        GameManager.instance.Panel.SetActive(false);
        GameManager.instance.ClueText.text = GameManager.instance.CluesCollected.ToString();
    }
}
