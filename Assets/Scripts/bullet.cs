using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject Gun;
    public AudioSource gunshot;
    private BoxCollider boxCollider;
    public int Points;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = Gun.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void ActivateBullet()
    {
        StartCoroutine(ActivateColliderForSeconds(0.1f));
        gunshot.Play();
    }
    IEnumerator ActivateColliderForSeconds(float seconds)
    {
        boxCollider.enabled = true;

        yield return new WaitForSeconds(seconds);

        boxCollider.enabled = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("blue"))
        {
            Destroy(other.gameObject);
            Debug.Log("blue");
            Points++;
        }
        if (other.CompareTag("red"))
        {
            Destroy(other.gameObject);
            Debug.Log("red");
            Points = Points + 3;
        }
        if (other.CompareTag("purple"))
        {
            Destroy(other.gameObject);
            Debug.Log("purple");
            Points = Points + 5;
        }
    }
}
