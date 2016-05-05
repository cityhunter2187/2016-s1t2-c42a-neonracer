using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class itemPickup : MonoBehaviour {

    public int currentItem;
    public GameObject shell;
    public GameObject banana;
    public int randomItem;
    public bool hasItem = false;
    public List<GameObject> items;
    public GameObject box;
    public Sprite ability1, ability2;
    Vector3 boxPos;

    void Start()
    {
        //items.Add(shell);
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "ItemBox")
        {
            if (hasItem == false)
            {
                boxPos = col.gameObject.transform.position;
                randomItem = Random.Range(1, 3);
                hasItem = true;
                Destroy(col.gameObject);
                if (randomItem == 1)
                {
                    if (items.Count < 1)
                    {

                        items.Add(shell);


                    }
                }
                if (randomItem == 2)
                {
                    if (items.Count < 1)
                    {
                        items.Add(banana);

                    }
                }
                StartCoroutine(spawnBox());

            }
        }
    }
    IEnumerator spawnBox()
    {
        yield return new WaitForSeconds(1);
        Instantiate(box, boxPos, Quaternion.identity);

    }

    
}
