using UnityEngine;

public class BossPhase2 : IBossPhase
{
    private Transform transform;
    private float t;
    private int scale;
    public BossPhase2(Transform transform)
    {
        scale = 1;
        this.transform = transform;
    }

    public void Execute()
    {
        t += Time.deltaTime;
        if (t >= scale)
        {
            scale++;
        }
        transform.localScale=Vector3.one*scale;
    }
}
