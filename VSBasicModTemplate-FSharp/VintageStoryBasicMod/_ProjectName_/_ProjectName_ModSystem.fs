namespace _ProjectName_

open Vintagestory.API.Client
open Vintagestory.API.Server
open Vintagestory.API.Config
open Vintagestory.API.Common

type _ProjectName_ModSystem() =
    inherit ModSystem()

    // Called on server and client
    // Useful for registering block/entity classes on both sides
    override this.Start(api: ICoreAPI) =
        this.Mod.Logger.Notification($"Hello from template mod: {api.Side}")

    override this.StartServerSide(api: ICoreServerAPI) =
        this.Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("_modid_:hello"))

    override this.StartClientSide(api: ICoreClientAPI) =
        this.Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("_modid_:hello"))

