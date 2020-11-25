using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogScript : MonoBehaviour
{

    public GameObject Player;
    public PlayerController PC;
    public float SocializeRate = 0f;
    public float SocializeTimer = 0f;
    public float SocializeCoolDown = 10f;
    //public int SocialMeter = 0;
    public Image SocialFG;
    public float MaxSocial = 100f;
    public float TimesSocialized = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PC = Player.GetComponent<PlayerController>();
        // SocialMeter.fillAmount = 1;
        SocialFG.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //FoodMeter.SetMeter(SocializeRate / 100f);
        SocializeTimer += Time.deltaTime;
        if (SocializeTimer > 10)
        {
            SocializeTimer = 10;
        }
               
    }



    private void OnTriggerEnter(Collider other)
    {

       if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collision detected");
            if (SocializeTimer >= SocializeCoolDown) {
                PC.Socialize += 10;
                SocializeTimer = SocializeRate;
                TimesSocialized += 1;
                SocialFG.fillAmount = (TimesSocialized * 10) / MaxSocial;
                Debug.Log(PC.Socialize);
            }
            else
            {
                Debug.Log("Cooldown has not run out yet " + SocializeTimer);
            }
        }
    }
}
