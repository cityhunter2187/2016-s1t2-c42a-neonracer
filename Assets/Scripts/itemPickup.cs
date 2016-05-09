using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class itemPickup : MonoBehaviour {

    public int currentItem;
    public GameObject shell;
    public GameObject banana;
    public GameObject boost;
    public bool hasItem = false;
    public List<GameObject> items;
    public GameObject box;
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
        if(col.gameObject.tag == "ItemBox")
        {
            boxPos = col.gameObject.transform.position;
            int randomItem = Random.Range(1, 4);
            hasItem = true;
            Destroy(col.gameObject);
            if(randomItem == 1)
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
            if (randomItem == 3)
            {
                if (items.Count < 1)
                {
                    items.Add(banana);
                }
            }
            StartCoroutine(spawnBox());

        }
    }
    IEnumerator spawnBox()
    {
        yield return new WaitForSeconds(1);
        Instantiate(box, boxPos, Quaternion.identity);

    }
}
