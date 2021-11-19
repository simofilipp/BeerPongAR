using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.ARDK.AR;
using Niantic.ARDK.Extensions;
using Niantic.ARDK.AR.ARSessionEventArgs;
using Niantic.ARDK.AR.HitTest;
using Niantic.ARDK.Utilities;
using Niantic.ARDKExamples.Helpers;
using UnityEngine.UI;


public enum StatoApp
{
    PiazzaBicchiere,
    LanciaPalle
}
public class CursorManager : MonoBehaviour
{
    public GameObject bicchierePrefab;
    public GameObject pallinaPrefab;
    public Transform puntatore;
    public GameObject arMesh;

    ARDepthManager _arDepthManager;
    ARPlaneManager _arPlaneManager;
    ARCursorRenderer _arCursorRenderer;

    [SerializeField] float forceImpulse;
    [SerializeField] int lanci;

    bool stoCaricando;
    float tempoLancio;
    public float forzaCaricata;

    public Image carlo;

    

    StatoApp statocorrente = StatoApp.PiazzaBicchiere;

    // Start is called before the first frame update
    void Start()
    {
        _arDepthManager = GetComponent<ARDepthManager>();
        _arPlaneManager = GetComponent<ARPlaneManager>();
        _arCursorRenderer = GetComponent<ARCursorRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (stoCaricando && tempoLancio <= 3f)
        {
            tempoLancio += Time.deltaTime;
            //calcola quanto tenuto premuto
            forzaCaricata = (tempoLancio * forceImpulse) / 3;

            //
            carlo.fillAmount = forzaCaricata / 2;
        }

        if (Input.touchCount > 0)
        {
            var tocco = Input.GetTouch(0);

            //pallina
            if (statocorrente == StatoApp.LanciaPalle)
            {
                //premo
                if (tocco.phase == TouchPhase.Began && lanci > 0)
                {
                    stoCaricando = true;
                }

                //rilascio
                if (tocco.phase == TouchPhase.Ended && lanci > 0)
                {

                    var pallina = Instantiate(pallinaPrefab, puntatore.position, puntatore.rotation);
                    pallina.GetComponent<Rigidbody>().AddForce(puntatore.forward * forzaCaricata / 2.5f, ForceMode.Impulse);
                    pallina.GetComponent<Rigidbody>().AddForce(puntatore.up * forzaCaricata, ForceMode.Impulse);

                    EseguitoUnLancio();
                }
            }

            //bicchiere
            if (tocco.phase == TouchPhase.Began && statocorrente == StatoApp.PiazzaBicchiere)
            {
                var bicchiere = Instantiate(bicchierePrefab, 
                                            _arDepthManager.DepthBufferProcessor.GetWorldPosition
                                                                                 (Screen.width / 2, Screen.height / 2), bicchierePrefab.transform.rotation);

                Deactive();
            }

            
        }
    }
    
    void EseguitoUnLancio()
    {
        lanci--;
        stoCaricando = false;
        tempoLancio = 0;

        //
        carlo.fillAmount = 0;
    }

    private void Deactive()
    {
        //_arDepthManager.enabled = false;
        //_arCursorRenderer.enabled = false;
        Destroy(_arCursorRenderer);
        _arCursorRenderer = null;

        //_arPlaneManager.enabled = false;
        //this.enabled = false;
        statocorrente = StatoApp.LanciaPalle;
        arMesh.SetActive(true);
    }
}
