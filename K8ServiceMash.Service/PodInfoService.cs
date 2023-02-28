using K8ServiceMash.Core;

namespace K8ServiceMash.Service;
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
