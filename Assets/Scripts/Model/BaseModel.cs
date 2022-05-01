using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class BaseModel : MonoBehaviour
{
    Dictionary<string, PropertyModel<object>> Properties = new Dictionary<string, PropertyModel<object>>();
    Tween modelProcess;

    public abstract void InitializeModel();
    public virtual void PlayModel(float playbackSpeed)
    {
        modelProcess.Kill();
        modelProcess = DOTween.To(() => 0f, (v) => ModelCycleExecute(v), 1f, playbackSpeed);
    }
    protected abstract void SetStartValues();
    protected abstract void ModelCycleExecute(float i);

}
