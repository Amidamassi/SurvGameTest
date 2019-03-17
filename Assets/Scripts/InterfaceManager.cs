using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField] GameObject craftTypes;
    [SerializeField] Image hpBar;
    [SerializeField] Image hungryBar;
    [SerializeField] Image heatBar;
    [SerializeField] Image tirednessBar;
    [SerializeField] Image moodBar;
    private Canvas interfaceCanvas;
    private Image[] itemsSprite;
    private float z;
    private void Awake()
    {
        itemsSprite = new Image[10];
        interfaceCanvas=hpBar.GetComponentInParent<Canvas>();
        for (int i = 0; i < itemsSprite.Length; i++)
        {
            if (i == 5)
            {
                z = 1;
            }
            itemsSprite[i] = Instantiate(Resources.Load<Image>("Inventory/" + "TestIm"), interfaceCanvas.transform);
            itemsSprite[i].transform.localPosition = new Vector3(-455+i*50-z*250, -325-40*z, 0);
            
        }

    }
    private bool openCraft;
    private GameObject craftTypeView;
    private void Update()
    {
        hpBar.fillAmount = PlayerManager.playerStats.hp / PlayerManager.playerStats.maxHP;
        hungryBar.fillAmount = PlayerManager.playerStats.hungry / PlayerManager.playerStats.maxHungry;
        heatBar.fillAmount = PlayerManager.playerStats.heat / PlayerManager.playerStats.maxHeat;
        tirednessBar.fillAmount = PlayerManager.playerStats.tiredness / PlayerManager.playerStats.maxTiredness;
        moodBar.fillAmount = PlayerManager.playerStats.mood / PlayerManager.playerStats.maxMood;
        InventoryDraw();

    }
    public void OpenCraft()
    {
        craftTypes.SetActive (!craftTypes.activeSelf);
    }
    public void CraftType(string typeName)
    {
        Destroy(craftTypeView);
        craftTypeView = Resources.Load<GameObject>("Craft/" + typeName);
        craftTypeView = Instantiate(craftTypeView,craftTypes.transform);
    }
    private void InventoryDraw()
    {
        for(int i = 0; i < InventoryManager.items.Length;i++)
        {
            itemsSprite[i].sprite= Resources.Load<Sprite>("Inventory/" +InventoryManager.items[i].type+"/"+ InventoryManager.items[i].name);
        }
    }
}
