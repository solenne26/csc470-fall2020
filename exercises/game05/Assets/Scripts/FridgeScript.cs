using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FridgeScript : MonoBehaviour
{

    public float Food = 15f;
    public GameObject Player;
    public PlayerController PC;
    //public int FoodMeter = 50;
    public Image HungerFG; 
    public float MaxHunger = 100f;
    public float TimesFed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PC = Player.GetComponent < PlayerController >();
        HungerFG.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //FoodMeter.SetMeter(Food / 100f);
        //nameText.text = unit.unitName;
        //namePanel.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Food > 0)
            {
                PC.Hunger += 10;
                Food -= 5;
                TimesFed -= 1;
                HungerFG.fillAmount = (TimesFed * 10) / MaxHunger;
            }
            else
            {

            }
        }

    



        Debug.Log("The new hunger is " + PC.Hunger + "The new food is " + Food);
      
        
    }
}
