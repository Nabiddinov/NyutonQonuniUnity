using UnityEditor;
using UnityEngine;

public partial class ftModelPostProcessor : ftModelPostProcessorInternal
{
    public override void UnwrapXatlas(Mesh m, UnwrapParam param)
    {
        xatlas.Unwrap(m, uparams);
    }
}

