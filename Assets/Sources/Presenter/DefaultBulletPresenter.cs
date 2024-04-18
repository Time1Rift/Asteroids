using UnityEngine;

public class DefaultBulletPresenter : Presenter
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out EnemyPresenter enemy))
            Destroy();
    }
}