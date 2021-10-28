using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(WaitBeforeDestroy());
    }
    IEnumerator WaitBeforeDestroy()
    {
        yield return new WaitForSeconds(1.6f);
        Destroy(particle);
    }
}
