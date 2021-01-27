using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBluePrint standardTurret;
    public TurretBluePrint missileLauncher;
    public TurretBluePrint LazerBeamer;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        buildManager.SelectTurretToBuild(missileLauncher);
    }
    public void SelectLazerBeamer()
    {
        buildManager.SelectTurretToBuild(LazerBeamer);
    }
}
