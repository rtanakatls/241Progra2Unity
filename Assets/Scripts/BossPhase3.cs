using UnityEngine;

public class BossPhase3 : IBossPhase
{
    private Transform transform;
    public BossPhase3(Transform transform)
    {
        this.transform = transform;
    }

    public void Execute()
    {
        transform.Rotate(Vector3.one*30);
    }
}
