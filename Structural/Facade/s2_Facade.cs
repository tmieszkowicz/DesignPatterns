
namespace DesignPatterns.Structural.Facade;

public class s2_Facade()
{
    public async Task RunAsync()
    {
        var castingFacade = new CastingFacade(new DeviceExplorer());

        await castingFacade.CastAsync(
            deviceId: Guid.NewGuid(),
            videoId: Guid.NewGuid());
    }
}