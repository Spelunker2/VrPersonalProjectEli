using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject startbutton;
    private CapsuleCollider capsuleCollider;
    public GameObject pedestal;
    // Start is called before the first frame update
    void Start()
    {
       capsuleCollider = startbutton.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        pedestal.SetActive(false);
    }
}
