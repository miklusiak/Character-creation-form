using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace Projekt
{
    public class Danger
    {
        public static List<Thread> threads = new List<Thread>();
        
        public static void Participants()
        {
            //security
            Soldier c1 = new Soldier();
            Soldier c2 = new Soldier();
            //family & coworkers
            Clerk c3 = new Clerk();
            Dancer c4 = new Dancer();
            Receptionist c5 = new Receptionist();
            Analyst c6 = new Analyst();
            Mathematician c7 = new Mathematician();
            Dancer c8 = new Dancer();

            BlackBlouse cc1 = new BlackBlouse(c1);
            BlackBlouse cc2 = new BlackBlouse(c2);
            WhiteShirt cc3 = new WhiteShirt(c3);
            BlackBlouse cc4 = new BlackBlouse(c4);
            WhiteShirt cc5 = new WhiteShirt(c5);
            WhiteShirt cc6 = new WhiteShirt(c6);
            ColorfulT_Shirt cc7 = new ColorfulT_Shirt(c7);
            ColorfulT_Shirt cc8 = new ColorfulT_Shirt(c8);

            BlackTrousers ccc1 = new BlackTrousers(cc1);
            BlackTrousers ccc2 = new BlackTrousers(cc2);
            BlackTrousers ccc3 = new BlackTrousers(cc3);
            CargoPants ccc4 = new CargoPants(cc4);
            BlackTrousers ccc5 = new BlackTrousers(cc5);
            BlueJeans ccc6 = new BlueJeans(cc6);
            BlueJeans ccc7 = new BlueJeans(cc7);
            BlackTrousers ccc8 = new BlackTrousers(cc8);

            MilitaryBoots d1 = new MilitaryBoots(ccc1);
            MilitaryBoots d2 = new MilitaryBoots(ccc2);
            ElegantShoes d3 = new ElegantShoes(ccc3);
            MilitaryBoots d4 = new MilitaryBoots(ccc4);
            ElegantShoes d5 = new ElegantShoes(ccc5);
            Sneakers d6 = new Sneakers(ccc6);
            Sneakers d7 = new Sneakers(ccc7);
            MilitaryBoots d8 = new MilitaryBoots(ccc8);

            Tattoo e1 = new Tattoo(d1);
            Tattoo e2 = new Tattoo(d2);
            Birthmark e3 = new Birthmark(d3);
            Tattoo e4 = new Tattoo(d4);
            Scar e5 = new Scar(d5);
            Birthmark e6 = new Birthmark(d6);
            Scar e7 = new Scar(d7);
            Birthmark e8 = new Birthmark(d8);

            NPC npc1 = new NPC(e1, 34, 12, 34, 10);
            NPC npc2 = new NPC(e2, 34, 14, 34, 16);
            NPC npc3 = new NPC(e3, 37, 5, 40, 6);
            NPC npc4 = new NPC(e4, 105, 15, 100, 15);
            NPC npc5 = new NPC(e5, 107, 20, 105, 19);
            NPC npc6 = new NPC(e6, 105, 14, 100, 14);
            NPC npc7 = new NPC(e7, 73, 21, 74, 22);
            NPC npc8_1 = new NPC(e8, 45, 14, 49, 15);

            List<NPC> npcs = new List<NPC>
            {
                //npc1,
                //npc2,
                //npc3,
                //npc4,
                //npc5,
                npc6,
                //npc7,
                //npc8_1
            };

            foreach(NPC npc in npcs)
            {
                Thread thread = new Thread(new ThreadStart(npc.RunRunner));
                threads.Add(thread);
                thread.Start();
            }
        } 
        
        public static void Kill()
        {
            NPC.exit = false;

            foreach(Thread t in threads)
            {                
                t.Join();
            }
        }
    }
}
