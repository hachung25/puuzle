using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 

public class Loading : MonoBehaviour
{
    public TextMeshProUGUI loadingText; // nếu bạn dùng TextMeshPro
    public Button playButton;
    public string nextSceneName = "GamePlay"; // tên scene tiếp theo

    private void Start()
    {
        // Ẩn text và nút lúc đầu
        loadingText.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);

        // Gọi các hàm sau thời gian định sẵn
        Invoke("ShowLoadingText", 2f);
        Invoke("ShowPlayButton", 8f);

        // Gắn sự kiện click
        playButton.onClick.AddListener(OnPlayClicked);
    }

    void ShowLoadingText()
    {
        loadingText.gameObject.SetActive(true);
    }

    void ShowPlayButton()
    {
        playButton.gameObject.SetActive(true);
    }

    public void OnPlayClicked()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
