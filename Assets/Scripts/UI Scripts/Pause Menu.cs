using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private GameObject SettingsCanvas;
    [SerializeField] private GameObject creditsCanvas;
    [SerializeField] private GameObject mainmenuCanvas;

    [Header("Buttons")]
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    private bool isPause = false;

    private void Awake()
    {
        btnContinue.onClick.AddListener(OnContinueClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }

    void Start()
    {
        
    }

    void Update()
    {
        // Pause Game
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            isPause = !isPause;
            pauseCanvas.SetActive(isPause);
            
            if (isPause)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

    private void OnDestroy()
    {
        btnContinue.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
    }

    // Buttons Clicks Events
    private void OnContinueClicked()
    {
        isPause = !isPause;
        pauseCanvas.SetActive(isPause);
        Time.timeScale = 1;
    }
    
    private void OnSettingsClicked()
    {

    }
    private void OnCreditsClicked()
    {

    }
    private void OnExitClicked()
    {

    }
}
