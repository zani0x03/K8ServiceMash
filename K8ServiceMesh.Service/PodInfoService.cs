using K8ServiceMesh.Core;

namespace K8ServiceMesh.Service;
public class PodInfoService:IPodInfoService
{
    public PodInfo GetPodInfo(){
        return new PodInfo(){
            IP = Environment.GetEnvironmentVariable("PodIP"),
            Name = Environment.GetEnvironmentVariable("PodName"),
            Namespace = Environment.GetEnvironmentVariable("PodNamespace")
        };
    }
}
