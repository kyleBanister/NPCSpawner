using UnityEngine;

public enum NPCType {
    Farmer,
    Beggar,
    ShopOwner
}

public class NPCFactory : MonoBehaviour {
    public NPCInterface GetNPC(NPCType type) {
        switch(type) {
            case NPCType.Beggar:
            NPCInterface beggar = new Beggar();
            return beggar;
            case NPCType.Farmer:
            NPCInterface farmer = new Farmer();
            return farmer;
            case NPCType.ShopOwner:
            NPCInterface shopOwner = new ShopOwner();
            return shopOwner;
        }
        return null;
    }
}
