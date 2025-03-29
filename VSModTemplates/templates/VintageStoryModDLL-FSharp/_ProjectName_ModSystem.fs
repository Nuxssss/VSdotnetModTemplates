#if AddSampleCode
open Vintagestory.API.Client
open Vintagestory.API.Server
open Vintagestory.API.Config
#endif
open Vintagestory.API.Common

[<assembly: ModInfo("_ProjectName_", "_ProjectName_",
                    Authors = [|"Unknown"|],
                    Description = "This is a sample mod",
                    Version = "1.0.0")>]
do()

namespace _ProjectName_

type _ProjectName_ModSystem() =
    inherit ModSystem()

#if AddSampleCode

    // Called on server and client
    // Useful for registering block/entity classes on both sides
    override this.Start(api: ICoreAPI) =
        Mod.Logger.Notification("Hello from template mod: " + api.Side.ToString())

    override this.StartServerSide(api: ICoreServerAPI) =
        Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("_ProjectName_:hello"))

    override this.StartClientSide(api: ICoreClientAPI) =
        Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("_ProjectName_:hello"))
#endif

