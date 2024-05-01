using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private IBossPhase currentPhase;

    
    void Awake()
    {
       StartCoroutine(ChangePhase());
    }

    IEnumerator ChangePhase()
    {
        currentPhase=new BossPhase1(GetComponent<Rigidbody>());
        yield return new WaitForSeconds(5);
        currentPhase=new BossPhase2(transform);
        yield return new WaitForSeconds(5);
        currentPhase=new BossPhase3(transform);

    }

    // Update is called once per frame
    void Update()
    {
        currentPhase.Execute();
    }
}
