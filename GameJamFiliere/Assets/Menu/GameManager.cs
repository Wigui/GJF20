using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    public GameObject GetCar
    {
        get { return m_loadedCar; }
    }

    public Material GetMaterial
    {
        get { return m_loadedMaterial; }
    }

    public void LoadCar(CarType carType)
    {
        switch (carType)
        {
            case CarType.CITROEN_C2:
                m_loadedCar = m_carC2;
                break;

            case CarType.PEUGEOT_205:
                m_loadedCar = m_car205;
                break;

            default:
                m_loadedCar = null;
                print("Incorrect car type load.");
                break;
        }
    }

    public void LoadMaterial(CarMaterial carMaterial)
    {
        switch (carMaterial)
        {
            case CarMaterial.C2_BASIC:
                m_loadedMaterial = m_materialC2Basic;
                break;

            case CarMaterial.C2_RALLY:
                m_loadedMaterial = m_materialC2Rally;
                break;

            case CarMaterial.P205_BASIC:
                m_loadedMaterial = m_materialP205Basic;
                break;

            case CarMaterial.P205_RALLY:
                m_loadedMaterial = m_materialP205Rally;
                break;

            default:
                print("Incorrect car type load.");
                break;
        }
    }

    public enum CarType
    {
        CITROEN_C2,
        PEUGEOT_205,
    };

    public enum CarMaterial
    {
        C2_BASIC,
        P205_BASIC,
        C2_RALLY,
        P205_RALLY,
    };

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
    }

    private void Update()
    {
    }

    [Header("Car Prefabs")]
    [SerializeField]
    private GameObject m_carC2 = null;
    [SerializeField]
    private GameObject m_car205 = null;

    [Header("Car Materials")]
    [SerializeField]
    private Material m_materialC2Basic = null;
    [SerializeField]
    private Material m_materialC2Rally = null;
    [SerializeField]
    private Material m_materialP205Basic = null;
    [SerializeField]
    private Material m_materialP205Rally = null;

    private GameObject m_loadedCar = null;
    private Material m_loadedMaterial = null;
}