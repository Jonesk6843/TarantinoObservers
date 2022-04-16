using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class loadWorld
    {
        Room Entrance = new Room(500, "Entrance", "The entrance to this castle is battered.Maybe from a battle long passed.Amidst the rubble lies broken swords, tattered armor, and shattered frames.By the looks of undamaged " +
                     "weapons piled in the corner of the entrance, you may not be the first one here…and definitely not the last…");
        Room AbandonedLobbyRoom = new Room(501, "Abandoned Lobby", "Where the knights congregated…used to that is. This is the only room that seemed to be the most intact as if someone" +
            "had been fixing it up for some time. At the center of the room, laid a shattered chandelier, except the shards seemed to be swept around the chandelier.");
        Room Hallway1 = new Room(502, "Hallway1", "This hallway is littered with the glass of the windows letting the sun in, rubble, and shattered vases that held beautiful flowers. There are many rooms down the hall." +
            " You wonder: Is there any loot left in these rooms?");
        Room Hallway2 = new Room(503, "Hallway2", "Similar to the first hallway, however, there were no windows and in their place was replaced with fading portraits of," + 
            "who you assumed to be the king of this castle. Down the hall, there were two great doors.You may be approaching something great…");
        Room King = new Room(504, "King's Quarters", "Beyond the great doors, lead you to the official residence of the crown. Illuminated by six great windows, three on the left and " + 
            "right sides of the room. The golden throne glimmered in the sunlight, dazzling its authority unto all of those who gaze upon it. It’s rather surprising that the throne has been left untouched. You wonder why…");
    }
}
