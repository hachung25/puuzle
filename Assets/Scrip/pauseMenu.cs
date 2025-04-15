using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class pauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject onSoundd;
    public GameObject offSoundd;
    public GameObject buttondk;
    public GameObject Scource;
    public Slider volumeSlider;
    public AudioSource audioSource;


    void Start()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        volumeSlider.value = audioSource.volume;

        // Đăng ký sự kiện thay đổi
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void PauseGame()
    {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f; // Dừng gam
            buttondk.SetActive(false);
            Scource.SetActive(false);
            
    }

    public void falsePause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Tiếp tục game
        buttondk.SetActive(true);
        Scource.SetActive(true);
        
    }
    public void RestartGame()
    {
        Time.timeScale = 1f; // Đảm bảo thời gian chạy lại
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    void SetVolume(float value)
    {
        audioSource.volume = value;
    }
 
}
