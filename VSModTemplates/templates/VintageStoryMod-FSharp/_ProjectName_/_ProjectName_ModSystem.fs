namespace _ProjectName_

#if AddSampleCode
open Vintagestory.API.Client
open Vintagestory.API.Server
open Vintagestory.API.Config
#endif
open Vintagestory.API.Common

type _ProjectName_ModSystem() =
    inherit ModSystem()

#if AddSampleCode
    // Called on server and client
    // Useful for registering block/entity classes on both sides
    override this.Start(api: ICoreAPI) =
        Mod.Logger.Notification("Hello from template mod: " + api.Side.ToString())

    override this.StartServerSide(api: ICoreServerAPI) =
        Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("_modid_:hello"))

    override this.StartClientSide(api: ICoreClientAPI) =
        Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("_modid_:hello"))
#endif
