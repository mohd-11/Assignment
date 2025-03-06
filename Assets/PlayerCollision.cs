using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // عندما يصطدم اللاعب بالـ obstacle
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // إعادة تحميل المشهد الحالي
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
