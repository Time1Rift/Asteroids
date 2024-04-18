using UnityEngine;

public class EnemyPresenter : Presenter
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out DefaultBulletPresenter bullet))
            IdentifyCollision();
    }

    protected virtual void IdentifyCollision() => Destroy();
}