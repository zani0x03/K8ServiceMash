using K8ServiceMesh.Core;

namespace K8ServiceMesh.Service;
public interface IPodInfoService
{
    PodInfo GetPodInfo();
}