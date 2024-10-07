using SC = System.Console;



bool Running = true;
bool INput = true;
bool Convertsucsses = false;
bool validAnswer;
bool Unafordeble = false;

int stockCheese = 2;
int stockMonkey = 3;
int stockSugar = 1;
int j = 0;
int i;
int itemNum = 0;
int intCuantety = 0;
int Baugt = 0;
int Cheese = 0;
int Monkeys = 0;
int Sugar = 0;

float Cost = 0;
float Money = 100;

string strCuantety;
string Item;
string itemId;
string[] Choices = ["1", "2", "3"];






SC.WriteLine(@$"
                            This is the store! Here you can spend your money on stupid things, 
                               unfortunatly right now, we only have trhee items for sale.");

while (Running)
{
    Store();
}

void Store()
{
    Items();
    Cuantity();
}



















void Items()
{
    j = 0;
    Convertsucsses = false;
    //Cost = 0;
    // tab 7 text


    while (Convertsucsses == false)
    {

        if (Baugt > 0) { SC.WriteLine(@$"Owned Cheese :{Cheese}:    Monkeys :{Monkeys}:     Sugar :{Sugar}:"); }
        SC.WriteLine(@$"

                                                Your Avaleble Money; {Money} kr

                                 ___   __   ___       ___   ___    ___       ___   ____    ___ 
                                |  _| /_ | |_  |     |  _| |__ \  |_  |     |  _| |___ \  |_  |
                                | |    | |   | |     | |      ) |   | |     | |     __) |   | |
                                | |    | |   | |     | |     / /    | |     | |    |__ <    | |
                                | |    | |   | |     | |    / /_    | |     | |    ___) |   | |
                                | |_   |_|  _| |     | |_  |____|  _| |     | |_  |____/   _| |
                                |___|      |___|     |___|        |___|     |___|         |___|
                                     Cheese                Monkey                  Sugar                                                          
                                  Kost: 17.45kr         Kost: 36.99kr          Kost: 69.69kr


                        If You want to buy an item, type the number for said item and then press Enther.
    ");


        if (Convertsucsses == false && j > 0)
        {
            SC.WriteLine(@"
                                                Wrong item index, try again");
        }
        Cost = 0;
        Item = SC.ReadLine();
        Convertsucsses = int.TryParse(Item, out itemNum); // försöker parsa om mislykas går vidare med 0
        validAnswer = Choices.Contains(Item);
        if (validAnswer == false) { Convertsucsses = false; }

        j++;


        SC.Clear();
    } // while Convertsucsses == false

} // Item



















void Cuantity()
{
    i = 1;
    j = 0;
    intCuantety = 0;
    while (i == 1)
    {

        if (stockCheese == 0 && itemNum == 1)
        {
            SC.WriteLine("We have unfortunetly run out of inventory for that item, plese chose another item");
            SC.ReadLine();
            itemNum = 0;
            i = 0;
        }

        if (stockMonkey == 0 && itemNum == 2)
        {
            SC.WriteLine("We have unfortunetly run out of inventory for that item, plese chose another item");
            SC.ReadLine();
            itemNum = 0;
            i = 0;
        }

        if (stockSugar == 0 && itemNum == 3)
        {
            SC.WriteLine("We have unfortunetly run out of inventory for that item, plese chose another item");
            SC.ReadLine();
            itemNum = 0;
            i = 0;
        }















        if (itemNum == 1)
        {
            SC.WriteLine(@$"
                              How many Chesses do you want to buy? They cost: 17.45 kr ech.
                                                  We have {stockCheese} in stock.
                    If you want to exit the buiyng, write Escape, otherwise write how many you want:
");

            if (Convertsucsses == false && j > 0)
            {
                SC.WriteLine(@"
                                        We only acepts numerical valius, try again");
            }

            if (intCuantety > stockCheese)
            {
                SC.WriteLine(@"            
            We unfortunelty dont have the recuiered inventory for your transaction plese chose a lower amount");
            }
            if (Convertsucsses == true && Money < Cost)
            {
                SC.WriteLine(@"            
            You unfortunetly do not have the requierd funds for the transaction, please aquier aditenal funds");
            }


            strCuantety = SC.ReadLine();
            Cost = 0;

            if(strCuantety.ToLower() == "escape"){
                i = 0;
            }

            Convertsucsses = int.TryParse(strCuantety, out intCuantety); // försöker parsa om mislykas går vidare med 0

            Cost = 17.45f * intCuantety;
            if (Convertsucsses == true && Money > Cost && intCuantety <= stockCheese)
            {
                SC.WriteLine($@"
                                              You have now baugt {intCuantety} Chesses.");
                SC.ReadLine();
                stockCheese = stockCheese - intCuantety;
                Cheese = +intCuantety;
                i = 0;
                Money = Money - Cost;
            }

        }














        else if (itemNum == 2)
        {

            SC.WriteLine(@$"
                              How many Monkeys do you want to buy? They cost: 36.99 kr ech.
                                                  We have {stockMonkey} in stock.
                        If you want to exit the buiyng, write Escape, otherwise write how many you want:
");

            if (Convertsucsses == false && j > 0)
            {
                SC.WriteLine(@"
                                        We only acepts numerical valius, try again");
            }

            if (intCuantety > stockMonkey)
            {
                SC.WriteLine(@"            
            We unfortunelty dont have the recuiered inventory for your transaction plese chose a lower amount");
            }
            if (Convertsucsses == true && Money < Cost || Money < 36.99f)
            {
                SC.WriteLine(@"            
            You unfortunetly do not have the requierd funds for the transaction, please aquier aditenal funds");
                Unafordeble = true;
                i = 0;
                SC.ReadLine();
            }

            if (Unafordeble == false)
            {
                strCuantety = SC.ReadLine();
                Cost = 0;

                if(strCuantety.ToLower() == "escape"){
                i = 0;
            }

                Convertsucsses = int.TryParse(strCuantety, out intCuantety); // försöker parsa om mislykas går vidare med 0

                Cost = 36.99f * intCuantety;
                if (Convertsucsses == true && Money > Cost && intCuantety <= stockMonkey)
                {
                    SC.WriteLine($@"
                                              You have now baugt {intCuantety} Monkeys.");
                    SC.ReadLine();
                    stockMonkey = stockMonkey - intCuantety;
                    Monkeys = +intCuantety;
                    i = 0;
                    Money = Money - Cost;
                }


            } // if (Unafordeble = false)

        }



















        else if (itemNum == 3)
        {

            SC.WriteLine(@$"
                              How mutch Sugar do you want to buy? They cost: 69.69 kr per bag.
                                                  We have {stockSugar} in stock.
                        If you want to exit the buiyng, write Escape, otherwise write how many you want:
");

            if (Convertsucsses == false && j > 0)
            {
                SC.WriteLine(@"
                                        We only acepts numerical valius, try again");
            }

            if (intCuantety > stockSugar)
            {
                SC.WriteLine(@"            
            We unfortunelty dont have the recuiered inventory for your transaction plese chose a lower amount");
            }
            if (Convertsucsses == true && Money < Cost || Money < 69.69f)
            {
                SC.WriteLine(@"            
            You unfortunetly do not have the requierd funds for the transaction, please aquier aditenal funds");
                Unafordeble = true;
                i = 0;
                SC.ReadLine();
            }

            if (Unafordeble == false)
            {
                strCuantety = SC.ReadLine();
                Cost = 0;

                if(strCuantety.ToLower() == "escape"){
                i = 0;
            }

                Convertsucsses = int.TryParse(strCuantety, out intCuantety); // försöker parsa om mislykas går vidare med 0

                Cost = 69.69f * intCuantety;
                if (Convertsucsses == true && Money > Cost && intCuantety <= stockSugar)
                {
                    SC.WriteLine($@"
                                              You have now baugt {intCuantety} bags of Sugar.");
                    SC.ReadLine();
                    stockSugar = stockSugar - intCuantety;
                    Sugar = +intCuantety;
                    i = 0;
                    Money = Money - Cost;
                }


            } // if (Unafordeble = false)


        }


















        //outPut();
        j++;
        //Convertsucsses = false;
        SC.Clear();

    } // while (i == 1)
      //if (Unafordeble = false){
    Baugt++;
    Unafordeble = false;
    //}

    if (Money < 17.45f)
    {
        SC.WriteLine("Your Unfortunatly broke, =/ .Therefore we dont want you here anymore.");
        SC.WriteLine(@$"You have bought  :{Cheese}:Cheese     :{Monkeys}:Monkeys      :{Sugar}:bags of Sugar");
        SC.ReadLine();
        Running = false;
        while (true)
        {
            SC.Clear();
            SC.WriteLine(@"
                                          ______________
                                        |\ ___________ /|
                                        | |  /|,| |   | |
      .-'\                              | | |,x,| |   | |     
   .-'  `/\                             | | |,x,' |   | |
.-'      `/\                            | | |/    |   | |
\         `/\                           | |    /] ,   | |
 \         `/\                          | |   [/ ()   | |
  \    _-   `/\       _.--.             | |       |   | |
   \    _-   `/`-..--\     )            | |       |   | |
    \    _-   `,','  /    ,')           | |       |   | |
     `-_   -   ` -- ~   ,','            | |      ,'   | |
      `-              ,','              | |   ,'      | |
       \,--.    ____==-~                |_|,'_________|_| 
        \   \_-~\                      
         `_-~_.-'                      
          \-~                          
                                      

    ");
            SC.ReadLine();
        }
    }

} // Cuantety
