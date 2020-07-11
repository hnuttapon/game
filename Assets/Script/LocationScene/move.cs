using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Animator walk;
    // Start is called before the first frame update
    void Start()
    {
        //walk = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            walk.GetComponent<Animator>().enabled = true;
            StartCoroutine(Wait());

        }
        else if(!transform.hasChanged)
        {
            walk.GetComponent<Animator>().enabled = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        transform.hasChanged = false;
    }
}
