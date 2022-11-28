using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : MonoBehaviour
{
    [SerializeField] private float bottleLife;

    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator DestroyBottle()
    {
        yield return new WaitForSeconds(bottleLife);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(DestroyBottle());
    }

}
