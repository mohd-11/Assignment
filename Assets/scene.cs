using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingWall : MonoBehaviour
{
    [Header("Wall Movement Settings")]
    [SerializeField] private float speed = 0.10f;          // سرعة حركة الجدار باتجاه اليسار

    [Header("Lose Scene Settings")]
    [SerializeField] private string loseSceneName = "LoseScene";

    void Update()
    {
        // التحريك باتجاه اليسار فقط
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    // في حال الاصطدام باللاعب
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // الانتقال إلى مشهد الخسارة
            SceneManager.LoadScene(loseSceneName);
        }
    }

    // إذا أردت استخدام الـTrigger بدلًا من الاصطدام العادي:
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(loseSceneName);
        }
    }
    */
}