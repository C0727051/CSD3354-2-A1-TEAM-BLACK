using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new CountrySide().Run();
           
        }
    }


    class CountrySide
    {
        public void Run()
        {
            Alst = new Village("Alst", false);
            Schvenig = new Village("Schvenig", false);
            Wessig = new Village("Wessig", true);
            Alst.distanceToEastVillage = 19;
            Alst.distanceToWestVillage = 14;
            Alst.west = Schvenig;
            Alst.east = Wessig;

            //Schvenig.distanceToNextVillage = 14;
            Schvenig.west = null;
            Schvenig.east = null;

            //Wessig.distanceToNextVillage = 14;
            Wessig.west = null;
            Wessig.east = null;
            this.TravelVillages(Alst);





        }







        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;
        public void TravelVillages(Village CurrentVillage)
        {
            try
            {
                if (CurrentVillage.isAstrildgeHere)
                {
                    Console.WriteLine("I found Dear Astrildge in {0}", CurrentVillage.VillageName);
                    Console.WriteLine("****************Feeling Happy!!!!****************** ");
                    return;
                }

                TravelVillages(CurrentVillage.west);
                TravelVillages(CurrentVillage.east);



            }
            catch(NullReferenceException nre)
            {

            }
        } 




       
    }


        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToEastVillage;
            public int distanceToWestVillage;
            public int distanceToPreviousVillage;
            public bool isAstrildgeHere;
        }
    }

