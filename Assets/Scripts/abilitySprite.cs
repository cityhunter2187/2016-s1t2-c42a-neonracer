using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class abilitySprite : MonoBehaviour {


    public GameObject player;
    public itemPickup itemP;
    public int itemScore;
    public Sprite shellSprite;
    public Sprite bananaSprite;
    public Sprite noAbility;
	// Use this for initialization
	void Start () {

        gameObject.GetComponent<itemPickup>();

        

	}
	
	// Update is called once per frame
	void Update () {

        itemScore = itemP.randomItem;

        if (Input.GetKey(KeyCode.Alpha1))
        {
            //changes the sprite to the ability
            this.gameObject.GetComponent<Image>().sprite = shellSprite;
            return;
        }

        if (itemScore == 0)
        {
            //changes the sprite to the ability
            this.gameObject.GetComponent<Image>().sprite = noAbility;
        }

        
        if(itemScore == 1)
        {
            this.gameObject.GetComponent<Image>().sprite = shellSprite;
        }

        if (itemScore == 2)
        {
            //changes the sprite to the ability
            this.gameObject.GetComponent<Image>().sprite = bananaSprite;
        }

    }
}
