using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] private GameObject mainMenuCanvas;

    [Header("Buttons")]
    [SerializeField] private Button btnStart;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    private void Awake()
    {
        btnStart.onClick.AddListener(OnStartClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnDestroy()
    {
        btnStart.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
    }

    // Custom Functions
    private void OnStartClicked()
    {

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
