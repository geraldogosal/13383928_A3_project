using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PacmanManager : MonoBehaviour
{
    private Tweener tweener;
    //[SerializeField] AudioSource moveSound = null;
    private List<GameObject> itemList;
    [SerializeField] GameObject item;
    private Vector3 pastPosition;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        itemList = new List<GameObject>();
        itemList.Add(item);
        //pastPosition = item.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //pastPosition = item.transform.position;
        if (item.transform.position == new Vector3(1.0f, -1.0f, 0.0f))
        {
            AddTween(new Vector3(6.0f, -1.0f, 0.0f), 1.5f);
            invertChecker(item);
        }

        else if (item.transform.position == new Vector3(6.0f, -1.0f, 0.0f))
        {
            AddTween(new Vector3(6.0f, -5.0f, 0.0f), 1.5f);
           
        }

        else if (item.transform.position == new Vector3(6.0f, -5.0f, 0.0f))
        {
            AddTween(new Vector3(1.0f, -5.0f, 0.0f), 1.5f);
            invertChecker(item);
        }

        else if (item.transform.position == new Vector3(1.0f, -5.0f, 0.0f))
        {
            AddTween(new Vector3(1.0f, -1.0f, 0.0f), 1.5f);
        
        }
    }
    private void AddTween(Vector3 endPosition, float duration)
    {
        bool added = false;
        foreach (GameObject item in itemList)
        {
            added = tweener.AddTween(item.transform, item.transform.position, endPosition, duration);
            if (added)
            {
                break;
            }
        }
    }
  

    private void inverted(GameObject item)
    {
        item.transform.localScale = new Vector3(transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
    }

    private void invertChecker(GameObject item)
    {
        if (item.transform.localScale.x > 0)
        {
            inverted(item);
        }
        else if (item.transform.localScale.x < 0)
        {
            inverted(item);
        }
    }

}
