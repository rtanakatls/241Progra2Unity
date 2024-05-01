using UnityEngine;

public class BossPhase1 : IBossPhase
{
    private Rigidbody rb;
    public BossPhase1(Rigidbody rb)
    {
        this.rb= rb;
    }

    public void Execute()
    {
        rb.velocity = rb.transform.forward;
    }
}
